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

            Console.WriteLine("Bicycle_type");
            var Bicycle_type = Console.ReadLine();
            Console.WriteLine("Bicycle_name");
            var Bicycle_name = Console.ReadLine();
            Console.WriteLine("Avilability");
            var Avilability = Convert.ToBoolean(Console.ReadLine());

            try
            {
                var NewBicycleBrand = new Bicycle_brand()
                {
                    Bicycle_type = Bicycle_type,
                    Bicycle_name = Bicycle_name,
                    Avilability = Avilability

                };
                _bicycleRentalDbContext.Bicycle_brands
                    .Add(NewBicycleBrand);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New BicycleBrand added successfully!");
                Console.WriteLine($"Bicycle_type: {NewBicycleBrand.Bicycle_type}");
                Console.WriteLine($"Bicycle_name: {NewBicycleBrand.Bicycle_name}");
                Console.WriteLine($"Avilability: {NewBicycleBrand.Avilability}");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
