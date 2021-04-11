using BicycleRental.Models;

namespace BicycleRental.Methods.ReturnObject
{
    public class ReturnBookingDetails
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public ReturnBookingDetails()
        {

        }

        public Booking_detail Return_BookingDetail(int booking_Id)
        {
            var _booking_detail = _bicycleRentalDbContext.Booking_details.Find(booking_Id);

            return _booking_detail;
        }
    }
}
