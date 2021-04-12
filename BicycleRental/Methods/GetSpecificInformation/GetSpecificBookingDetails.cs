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
        /// <summary>
        /// get specific booking detail info
        /// </summary>
        public void GetSpecificBookingDetailsInfo()
        {
            try
            {
                var bookingDetails = new GetAllBookingDetails();
                Console.WriteLine($"Here are all existing Booking Details:\n");
                bookingDetails.GetAllBookingDetailsInfo();

                Console.WriteLine($"\nChoose specific Booking Detail to view by entering Booking Id ");
                var userInput = Convert.ToInt32(Console.ReadLine());
                var bookingDetail = _bicycleRentalDbContext.Booking_details.Find(userInput);

                if (bookingDetail == null)
                {
                    Console.WriteLine("No bookingDetail was found..");
                    Visuals.ReturnToMainMenu();
                }

                Console.Clear();

                Console.WriteLine($"Your specific Booking Detail: ");
                Console.WriteLine($"Booking_id: {bookingDetail.Booking_id}");
                Console.WriteLine($"Booking_date: {bookingDetail.Booking_date.ToShortDateString()}");
                Console.WriteLine($"Return_due_date: {bookingDetail.Return_due_date.ToShortDateString()}");
                Console.WriteLine($"Rental_price: {bookingDetail.Rental_price}");
                Console.WriteLine($"Customer_id: {bookingDetail.Customer_id}");
                Console.WriteLine($"Bicycle_id: {bookingDetail.Bicycle_id}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
