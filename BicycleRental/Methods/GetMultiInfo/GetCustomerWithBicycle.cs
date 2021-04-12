using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleRental.Methods.GetMultiInfo
{
    public class GetCustomerWithBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public GetCustomerWithBicycle()
        {

        }

        /// <summary>
        /// Gets you the customer with booked bicycle
        /// </summary>
        public void GetCustomerWithBookingAndBicycle() 
        {
            try
            {
                var customer = new GetAllCustomers();
                customer.GetAllCustomersInfo();

                Console.WriteLine("Choose Customer With Bicycle to show by entering Customer Id: ");
                var customerId = Convert.ToInt32(Console.ReadLine());


                var getCustomerWithBookingWithBicycle = _bicycleRentalDbContext.Customers
                    .Include(g => g.Booking_details)
                    .ThenInclude(b => b.Bicycle)
                    .ThenInclude(b => b.Bicycle_brand)
                    .FirstOrDefault(g => g.Customer_id == customerId);

                Console.Clear();

                Console.WriteLine("Here is your customer with booking and bicycle:");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Customer First Name: {getCustomerWithBookingWithBicycle.Customer_First_Name}");
                Console.WriteLine($"Customer Last Name: {getCustomerWithBookingWithBicycle.Customer_Last_Name}");
                Console.WriteLine($"Customer Gender: {getCustomerWithBookingWithBicycle.Gender}");
                Console.WriteLine($"Customer Phone number: {getCustomerWithBookingWithBicycle.Phone_number}");
                Console.WriteLine($"Customer E_mail: {getCustomerWithBookingWithBicycle.E_mail}");
                Console.WriteLine("------------------------------------------");

                foreach (var item in getCustomerWithBookingWithBicycle.Booking_details)
                {
                    Console.WriteLine($"Booking_date: {item.Booking_date}");
                    Console.WriteLine($"Bicycle_type: {item.Bicycle.Bicycle_brand.Bicycle_type}");
                    Console.WriteLine($"Bicycle_name: {item.Bicycle.Bicycle_brand.Bicycle_name}");
                    Console.WriteLine($"Return_due_date: {item.Return_due_date}");
                    Console.WriteLine("----------------------------------------");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
            

        }
    }
}
