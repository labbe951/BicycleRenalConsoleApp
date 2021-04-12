using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;

namespace BicycleRental.Methods.UpdateMethods
{
    class UpdateBookingDetails
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public UpdateBookingDetails()
        {

        }

        public void UpdateExistingBookingDetails() 
        {
            try
            {

                var bookingDetail = new GetAllBookingDetails();
                bookingDetail.GetAllBookingDetailsInfo();

                Console.WriteLine("Choose Booking detail to update by entering Booking Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBookingDetail = new ReturnBookingDetails();
                var bookingDetailToUpdate = getBookingDetail.Return_BookingDetail(userinput);

                if (bookingDetailToUpdate == null)
                {
                    Console.WriteLine("No Booking Detail was found..");
                    Visuals.ReturnToMainMenu();
                }

                Console.WriteLine("Change Booking detail information");
                Console.WriteLine("");
                Console.WriteLine("Update Booking_date");
                bookingDetailToUpdate.Booking_date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Update Return_due_date");
                bookingDetailToUpdate.Return_due_date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Update Rental_price");
                bookingDetailToUpdate.Rental_price = float.Parse(Console.ReadLine());
                Console.WriteLine("Customer_id");
                bookingDetailToUpdate.Customer_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bicycle_id");
                bookingDetailToUpdate.Bicycle_id = Convert.ToInt32(Console.ReadLine());

                _bicycleRentalDbContext
                    .Booking_details
                    .Update(bookingDetailToUpdate);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine("Existing Booking detail updated successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Customer Booking_date: {bookingDetailToUpdate.Booking_date}");
                Console.WriteLine($"Customer Return_due_date: {bookingDetailToUpdate.Return_due_date}");
                Console.WriteLine($"Customer Rental_price: {bookingDetailToUpdate.Rental_price}");
                Console.WriteLine($"Customer Customer_id: {bookingDetailToUpdate.Customer_id}");
                Console.WriteLine($"Customer Bicycle_id: {bookingDetailToUpdate.Bicycle_id}");
                Console.WriteLine("---------------------------------------");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
