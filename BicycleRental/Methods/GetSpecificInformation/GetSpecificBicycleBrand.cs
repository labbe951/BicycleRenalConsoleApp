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
        /// <summary>
        /// Get specific bicycle brand info
        /// </summary>
        public void GetSpecificBicycleBrandInfo()
        {
            try
            {
                var bicycleBrands = new GetAllBicycleBrands();
                Console.WriteLine($"Here are all existing Bicycle Brands:\n");
                bicycleBrands.GetAllBicycleBrandsInfo();

                Console.WriteLine($"\nChoose specific Bicycle Brand to view by entering Bicycle Brand Id ");
                var userInput = Convert.ToInt32(Console.ReadLine());
                var bicycleBrand = _bicycleRentalDbContext.Bicycle_brands.Find(userInput);

                if (bicycleBrand == null)
                {
                    Console.WriteLine("No bicycleBrand was found..");
                    Visuals.ReturnToMainMenu();
                }

                Console.Clear();

                Console.WriteLine($"Your specific Bicycle Brand: ");
                Console.WriteLine($"Brand_id: {bicycleBrand.Brand_id}");
                Console.WriteLine($"Bicycle_type: {bicycleBrand.Bicycle_type}");
                Console.WriteLine($"Bicycle_name: {bicycleBrand.Bicycle_name}");
                Console.WriteLine($"Avilability: {bicycleBrand.Avilability}");
            }
            catch (Exception ex )
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
