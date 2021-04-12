using BicycleRental.Methods.GetAllInformation;
using System;

namespace BicycleRental.Methods.GetSpecificInformation
{
    public class GetSpecificBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public GetSpecificBicycle()
        {

        }
        /// <summary>
        /// Get specific bicycle info
        /// </summary>
        public void GetSpecificBicycleInfo()
        {
            try
            {
                var bicycles = new GetAllBicycles();
                Console.WriteLine($"Here are all existing Bicycles:\n");
                bicycles.GetAllBicyclesInfo();

                Console.WriteLine($"\nChoose specific Bicycle to view by entering Bicycle Id ");
                var userInput = Convert.ToInt32(Console.ReadLine());
                var bicycle = _bicycleRentalDbContext.Bicycles.Find(userInput);

                Console.Clear();

                Console.WriteLine($"Your specific Bicycle: ");
                Console.WriteLine($"Bicycle_id: {bicycle.Bicycle_id}");
                Console.WriteLine($"Brand_id: {bicycle.Brand_id}");
                Console.WriteLine($"Frame_number: {bicycle.Frame_number}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }
    }
}
