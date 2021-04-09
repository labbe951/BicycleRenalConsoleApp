using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BicycleRental.Methods.GetAllInformation
{
    public class GetAllBookingDetails
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public void GetAllBicycleBrandsInfo() 
        {
            var GetInfo = _bicycleRentalDbContext.Booking_details.ToList();

            foreach (var item in GetInfo)
            {
                Console.WriteLine($"Booking_id: {item.Booking_id}");
                Console.WriteLine($"Booking_date: {item.Booking_date}");
                Console.WriteLine($"Return_due_date: {item.Return_due_date}");
                Console.WriteLine($"Rental_price: {item.Rental_price}");
                Console.WriteLine($"Customer_id: {item.Customer_id}");
                Console.WriteLine($"Bicycle_id: {item.Bicycle_id}");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");

            }
        }
    }
}
