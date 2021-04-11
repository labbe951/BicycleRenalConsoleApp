using System;
using System.Linq;

namespace BicycleRental.Methods.GetAllInformation
{
    public class GetAllBicycleBrands
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public GetAllBicycleBrands()
        {

        }

        /// <summary>
        /// Get all existing Bicycle Brands
        /// </summary>
        public void GetAllBicycleBrandsInfo()
        {
            var GetInfo = _bicycleRentalDbContext.Bicycle_brands.ToList();


            foreach (var item in GetInfo)
            {
                Console.WriteLine("");
                Console.WriteLine($"Brand_id: { item.Brand_id}");
                Console.WriteLine($"Bicycle_type: {item.Bicycle_type}");
                Console.WriteLine($"Bicycle_name: {item.Bicycle_name}");
                Console.WriteLine($"Avilability: {item.Avilability}");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");

            }
        }
    }
}
