using System.Net;

namespace MagicVilla_VillaAPI.Models
{
    public class APIResponsecs
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccsess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result {  get; set; } 
    }
}
