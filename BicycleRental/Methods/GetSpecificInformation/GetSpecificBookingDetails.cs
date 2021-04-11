using BicycleRental.Methods.GetAllInformation;
using System;

namespace BicycleRental.Methods.GetSpecificInformation
{
    public class GetSpecificBookingDetails
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public GetSpecificBookingDetails()
        {

        }

        public void GetSpecificBookingDetailsInfo()
        {
            var BookingDetails = new GetAllBookingDetails();
            Console.WriteLine($"Here are all existing Booking Details:\n");
            BookingDetails.GetAllBookingDetailsInfo();

            Console.WriteLine($"\nChoose specific Booking Detail to view by entering Booking Id ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var BookingDetail = _bicycleRentalDbContext.Booking_details.Find(userInput);

            Console.Clear();

            Console.WriteLine($"Your specific Bicycle Brand: ");
            Console.WriteLine($"Booking_id: {BookingDetail.Booking_id}");
            Console.WriteLine($"Booking_date: {BookingDetail.Booking_date}");
            Console.WriteLine($"Return_due_date: {BookingDetail.Return_due_date}");
            Console.WriteLine($"Rental_price: {BookingDetail.Rental_price}");
            Console.WriteLine($"Customer_id: {BookingDetail.Customer_id}");
            Console.WriteLine($"Bicycle_id: {BookingDetail.Bicycle_id}");
        }
    }
}
