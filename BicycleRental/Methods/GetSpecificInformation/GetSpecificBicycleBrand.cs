using BicycleRental.Methods.GetAllInformation;
using System;

namespace BicycleRental.Methods.GetSpecificInformation
{
    class GetSpecificBicycleBrand
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public GetSpecificBicycleBrand()
        {

        }

        public void GetSpecificBicycleBrandInfo()
        {
            var BicycleBrands = new GetAllBicycleBrands();
            Console.WriteLine($"Here are all existing Bicycle Brands:\n");
            BicycleBrands.GetAllBicycleBrandsInfo();

            Console.WriteLine($"\nChoose specific Bicycle Brand to view by entering Bicycle Brand Id ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var BicycleBrand = _bicycleRentalDbContext.Bicycle_brands.Find(userInput);

            Console.Clear();

            Console.WriteLine($"Your specific Bicycle Brand: ");
            Console.WriteLine($"Brand_id: {BicycleBrand.Brand_id}");
            Console.WriteLine($"Bicycle_type: {BicycleBrand.Bicycle_type}");
            Console.WriteLine($"Bicycle_name: {BicycleBrand.Bicycle_name}");
            Console.WriteLine($"Avilability: {BicycleBrand.Avilability}");
        }
    }
}
