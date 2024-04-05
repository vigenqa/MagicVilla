using AutoMapper;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using MagicVilla_VillaAPI.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MagicVilla_VillaAPI.Controllers

{
    [Route("api/VillaNumberApi")]
    [ApiController]
    public class VillaNumberAPIController : Controller

    {
        protected APIResponsecs _response;
        private readonly IVillaNumberRepository _dbVillaNumber;
        private readonly IMapper _mapper;

        public VillaNumberAPIController(IVillaNumberRepository dbVilla, IMapper mapper)
        {
            _dbVillaNumber = dbVilla;
            _mapper = mapper;
            this._response = new();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponsecs>> GetVillaNumbers()
        {
            try
            {
                IEnumerable<VillaNumber> numberList = await _dbVillaNumber.GetAllAsync();
                _response.Result = _mapper.Map<List<VillaNumberDto>>(numberList);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccsess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };

            }
            return _response;
        }

        [HttpGet("{villaNo:int}", Name = "GetVillaNumbers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponsecs>> GetVillaNumber(int villaNo)
        {
            try
            {
                if (villaNo == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var villanumber = await _dbVillaNumber.GetAsync(u => u.VillaNo == villaNo);

                if (villanumber == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = _mapper.Map<VillaNumberDto>(villanumber);
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccsess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };

            }
            return _response;

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponsecs>> CreateVillaNumber([FromBody] VillaNumberCreateDTO createDto)
        {
            try
            {
                if (createDto == null)
                {
                    return BadRequest();
                }

                // Map VillaCreateDto to Villa
                VillaNumber villa = _mapper.Map<VillaNumber>(createDto);

                // Add the mapped entity to the database
                await _dbVillaNumber.CreateAsync(villa);

                // Map the created Villa back to VillaDto
                VillaNumberDto createdDto = _mapper.Map<VillaNumberDto>(villa);

                // Return the created VillaDto
                _response.Result = _mapper.Map<VillaNumberDto>(villa);
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetVilla", new { id = villa.VillaNo }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccsess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };

            }
            return _response;
        }


        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{villaNo:int}", Name = "DeleteVillaNumber")]
        public async Task<ActionResult<APIResponsecs>> DeleteVillaNumber(int villaNo)
        {
            try
            {
                if (villaNo == 0)
                {
                    return BadRequest();
                }
                var villanumber = await _dbVillaNumber.GetAsync(u => u.VillaNo == villaNo);
                if (villanumber == null)
                {
                    return NotFound();
                }
                await _dbVillaNumber.RemoveAsync(villanumber);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccsess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccsess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };

            }
            return _response;
        }

        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{villaNo:int}", Name = "UpdateVillaNumber")]
        public async Task<ActionResult<APIResponsecs>> UpdateVilla(int villaNo, [FromBody] VillaNumberUpdateDto updateDto)
        {
            try
            {
                if (updateDto == null || villaNo != updateDto.VillaNo)
                {
                    return BadRequest();
                }

                VillaNumber model = _mapper.Map<VillaNumber>(updateDto);
                await _dbVillaNumber.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccsess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccsess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };

            }
            return _response;
        }

    }
}
