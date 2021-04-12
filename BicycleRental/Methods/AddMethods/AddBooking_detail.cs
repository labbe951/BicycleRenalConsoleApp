using BicycleRental.Models;
using System;

namespace BicycleRental.Methods.AddMethods
{
    class AddBooking_detail
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public AddBooking_detail()
        {

        }

        /// <summary>
        /// Add new Booking Details
        /// </summary>
        public void AddNewBooking_detail()
        {

            try
            {
                Console.WriteLine("Return_due_date");
                var returnDueDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Rental_price");
                var rentalPrice = float.Parse(Console.ReadLine());
                Console.WriteLine("Customer_id");
                var customerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bicycle_id");
                var bicycleId = Convert.ToInt32(Console.ReadLine());

                var newBookingDetail = new Booking_detail()
                {
                    Booking_date = DateTime.Now,
                    Return_due_date = returnDueDate,
                    Rental_price = rentalPrice,
                    Customer_id = customerId,
                    Bicycle_id = bicycleId
                };
                _bicycleRentalDbContext.Booking_details
                    .Add(newBookingDetail);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New booking detail added successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Return_due_date: {newBookingDetail.Return_due_date.ToShortDateString()}");
                Console.WriteLine($"Rental_price: {newBookingDetail.Rental_price}");
                Console.WriteLine($"Customer_id: {newBookingDetail.Customer_id}");
                Console.WriteLine($"Bicycle_id: {newBookingDetail.Bicycle_id}");
                Console.WriteLine("---------------------------------------");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }
    }
}
