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

            try
            {
                var getInfo = _bicycleRentalDbContext.Bicycles.ToList();

                Console.Clear();


                foreach (var item in getInfo)
                {
                    Console.WriteLine($"Bicycle_id: {item.Bicycle_id}");
                    Console.WriteLine($"Brand_id: {item.Brand_id}");
                    Console.WriteLine($"Frame_number: {item.Frame_number}");
                    Console.WriteLine("");
                    Console.WriteLine("-------------------------------------");

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
