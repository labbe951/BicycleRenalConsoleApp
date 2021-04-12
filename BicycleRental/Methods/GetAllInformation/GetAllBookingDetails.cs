using System;
using System.Linq;

namespace BicycleRental.Methods.GetAllInformation
{
    public class GetAllBookingDetails
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public void GetAllBookingDetailsInfo()
        {
            var getInfo = _bicycleRentalDbContext.Booking_details.ToList();

            Console.Clear();

            foreach (var item in getInfo)
            {
                Console.WriteLine($"Booking_id: {item.Booking_id}");
                Console.WriteLine($"Booking_date: {item.Booking_date.ToShortDateString()}");
                Console.WriteLine($"Return_due_date: {item.Return_due_date.ToShortDateString()}");
                Console.WriteLine($"Rental_price: {item.Rental_price}");
                Console.WriteLine($"Customer_id: {item.Customer_id}");
                Console.WriteLine($"Bicycle_id: {item.Bicycle_id}");
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------");

            }
        }
    }
}
