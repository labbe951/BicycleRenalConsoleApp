using System;
using System.Linq;

namespace BicycleRental.Methods.GetAllInformation
{
    public class GetAllBicycles
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public GetAllBicycles()
        {

        }

        /// <summary>
        /// Get all existing Bicycles
        /// </summary>
        public void GetAllBicyclesInfo()
        {

            var GetInfo = _bicycleRentalDbContext.Bicycles.ToList();


            foreach (var item in GetInfo)
            {
                Console.WriteLine($"Bicycle_id: {item.Bicycle_id}");
                Console.WriteLine($"Brand_id: {item.Brand_id}");
                Console.WriteLine($"Frame_number: {item.Frame_number}");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");

            }
        }
    }
}
