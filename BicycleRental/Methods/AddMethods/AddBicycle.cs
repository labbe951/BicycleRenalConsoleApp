using BicycleRental.Models;
using System;

namespace BicycleRental.Methods.AddMethods
{
    public class AddBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public AddBicycle()
        {

        }

        /// <summary>
        /// Add new bicycle
        /// </summary>
        public void AddNewBicycle()
        {

            try
            {
                Console.WriteLine("Frame_number");
                var frameNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Brand_id");
                var brandId = Convert.ToInt32(Console.ReadLine());

                var newBicycle = new Bicycle()
                {
                    Frame_number = frameNumber,
                    Brand_id = brandId

                };

                _bicycleRentalDbContext.Bicycles
                    .Add(newBicycle);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New Bicycle added successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Bicycle Frame Number: {newBicycle.Frame_number}");
                Console.WriteLine($"Bicycle Brand Id: {newBicycle.Brand_id}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("");


            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }

    }
}

