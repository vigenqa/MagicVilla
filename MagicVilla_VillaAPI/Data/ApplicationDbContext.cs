using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Rayal Villa",
                    Details = "Villa Details",
                    ImageURL = "https://i.pinimg.com/736x/c9/63/7a/c9637a6a3716d65de5b91c38fbbd3f89.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 550,
                    Amenity = "",
                    CreeatedDate = DateTime.Now
                    
                },
                new Villa()
                {
                    Id = 2,
                    Name = "Ocean View Paradise",
                    Details = "Luxury beachfront villa with stunning ocean views",
                    ImageURL = "https://www.beachhousenassau.com/wp-content/uploads/2018/10/Beach_House_Nassau_Ocean_View_Room1.jpg",
                    Occupancy = 8,
                    Rate = 500,
                    Sqft = 1200,
                    Amenity = "Private pool, beach access, BBQ area",
                    CreeatedDate = DateTime.Now
                },
                new Villa()
                { 
                    Id = 3,
                    Name = "Mountain Retreat Cabin",
                    Details = "Cozy cabin nestled in the mountains, perfect for nature lovers",
                    ImageURL = "https://www.cabinsusa.com/uploads/images/units/828/828_1438040497_7935.jpg",
                    Occupancy = 4,
                    Rate = 150,
                    Sqft = 800,
                    Amenity = "Fireplace, hiking trails nearby, scenic views",
                    CreeatedDate = DateTime.Now

                },
                new Villa()
                {
                    Id = 4,
                    Name = "Urban Loft",
                    Details = "Chic loft apartment in the heart of the city",
                    ImageURL = "https://www.apartments.com/images/default-source/default-album/hero-photos/primary-hero-images/apartment-exterior-02-003.jpg?sfvrsn=f7bbd086_0",
                    Occupancy = 2,
                    Rate = 300,
                    Sqft = 700,
                    Amenity = "Rooftop terrace, modern furnishings, city skyline views",
                    CreeatedDate = DateTime.Now
                },
                new Villa()
                {
                    Id = 5,
                    Name = "Rustic Farmhouse",
                    Details = "Quaint farmhouse surrounded by rolling hills and fields",
                    ImageURL = "https://media.istockphoto.com/photos/old-rustic-farmhouse-picture-id157708876?k=20&m=157708876&s=612x612&w=0&h=iW5YlBeuE0rM40voaLtwQh-QBebZZD3igDn7AATi6Wg=",
                    Occupancy = 6,
                    Rate = 250,
                    Sqft = 1000,
                    Amenity = "Wrap-around porch, garden, farm-to-table dining",
                    CreeatedDate = DateTime.Now
                }
                );
        }
    }
}
