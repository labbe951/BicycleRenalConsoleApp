using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.DeleteMethods
{
    public class DeleteBooking_detail
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public DeleteBooking_detail()
        {

        }

        public void DeleteExistingCustomer()
        {
            try
            {

                var bookingDetails = new GetAllBookingDetails();
                bookingDetails.GetAllBookingDetailsInfo();

                Console.WriteLine("Choose booking detail to delete by entering Booking Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBookingDetail = new ReturnBookingDetails();
                var bookingDetailToDelete = getBookingDetail.Return_BookingDetail(userinput);

                _bicycleRentalDbContext
                    .Booking_details
                    .Remove(bookingDetailToDelete);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine($"Existing booking details with booking id: {bookingDetailToDelete.Booking_id} deleted successfully!");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
