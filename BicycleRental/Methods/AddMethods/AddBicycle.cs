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

            Console.WriteLine("Frame_number");
            var Frame_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Brand_id");
            var Brand_id = Convert.ToInt32(Console.ReadLine());

            try
            {
                var NewBicycle = new Bicycle()
                {
                    Frame_number = Frame_number,
                    Brand_id = Brand_id

                };
                _bicycleRentalDbContext.Bicycles
                    .Add(NewBicycle);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New Bicycle added successfully!");
                Console.WriteLine($"Bicycle Frame Number: {NewBicycle.Frame_number}");
                Console.WriteLine($"Bicycle Brand Id: {NewBicycle.Brand_id}");
                Console.WriteLine("");


            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }

    }
}

