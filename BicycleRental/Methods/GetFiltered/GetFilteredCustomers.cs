using BicycleRental.Methods.GetAllInformation;
using Figgle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleRental.Methods.GetFiltered
{
    class GetFilteredCustomers
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public GetFilteredCustomers()
        {

        }

        public void GetFilteredCustomersInfo() 
        {
       
            var getfilteredCustomer = _bicycleRentalDbContext.Customers
                .Where(c => c.Customer_First_Name
                .StartsWith("A"));

            Console.Clear();

            Console.WriteLine("Customers Name starting with letter A");
            
            Console.WriteLine("--------------------------");

            foreach (var Customer in getfilteredCustomer)
            {
                
                Console.WriteLine($"{Customer.Customer_First_Name}");
                Console.WriteLine($"{Customer.Customer_Last_Name}");
                Console.WriteLine($"{Customer.Gender}");
                Console.WriteLine($"{Customer.E_mail}");
                Console.WriteLine($"{Customer.Phone_number}");
                Console.WriteLine("---------------------");
            }
            
            

        }
    }
}
