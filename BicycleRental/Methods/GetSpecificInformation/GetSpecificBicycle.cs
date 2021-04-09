using BicycleRental.Methods.GetAllInformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.GetSpecificInformation
{
    public class GetSpecificBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public GetSpecificBicycle()
        {

        }
        public void GetSpecificBicycleInfo() 
        {
            var Bicycles = new GetAllBicycles();
            Console.WriteLine($"Here are all existing Bicycles:\n");
            Bicycles.GetAllBicyclesInfo();

            Console.WriteLine($"\nChoose specific Bicycle to view by entering Bicycle Id ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var Bicycle = _bicycleRentalDbContext.Bicycles.Find(userInput);

            Console.Clear();

            Console.WriteLine($"Your specific Bicycle: ");
            Console.WriteLine($"Bicycle_id: {Bicycle.Bicycle_id}");
            Console.WriteLine($"Brand_id: {Bicycle.Brand_id}");
            Console.WriteLine($"Frame_number: {Bicycle.Frame_number}");

        }
    }
}
