using BicycleRental.Models;
using System;

namespace BicycleRental.Methods.AddMethods
{
    public class AddBicycle_brand
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public AddBicycle_brand()
        {

        }

        /// <summary>
        /// Add new bicycle Brand
        /// </summary>
        public void AddNewBicycleBrand()
        {

            try
            {
                Console.WriteLine("Bicycle_type");
                var bicycleType = Console.ReadLine();
                Console.WriteLine("Bicycle_name");
                var bicycleName = Console.ReadLine();
                Console.WriteLine("Avilability");
                var avilability = Convert.ToBoolean(Console.ReadLine());

                var newBicycleBrand = new Bicycle_brand()
                {
                    Bicycle_type = bicycleType,
                    Bicycle_name = bicycleName,
                    Avilability = avilability

                };

                _bicycleRentalDbContext.Bicycle_brands
                    .Add(newBicycleBrand);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New Bicycle Brand added successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Bicycle_type: {newBicycleBrand.Bicycle_type}");
                Console.WriteLine($"Bicycle_name: {newBicycleBrand.Bicycle_name}");
                Console.WriteLine($"Avilability: {newBicycleBrand.Avilability}");
                Console.WriteLine("---------------------------------------");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
