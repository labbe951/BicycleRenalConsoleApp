using System;
using System.Linq;

namespace BicycleRental.Methods.GetAllInformation
{
    public class GetAllCustomers
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        /// <summary>
        /// Get all existing Customers
        /// </summary>
        public void GetAllCustomersInfo()
        {
            try
            {
                var getInfo = _bicycleRentalDbContext.Customers.ToList();

                Console.Clear();

                foreach (var item in getInfo)
                {
                    Console.WriteLine($"Customer_id: {item.Customer_id}");
                    Console.WriteLine($"Customer_First_Name: {item.Customer_First_Name}");
                    Console.WriteLine($"Customer_Last_Name: {item.Customer_Last_Name}");
                    Console.WriteLine($"Gender: {item.Gender}");
                    Console.WriteLine($"Phone_number: {item.Phone_number}");
                    Console.WriteLine($"E_mail: {item.E_mail}");
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
