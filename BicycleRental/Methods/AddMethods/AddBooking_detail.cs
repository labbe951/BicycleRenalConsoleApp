using System;
using System.Collections.Generic;
using System.Text;

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

            Console.WriteLine("Return_due_date");
            var Return_due_date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Rental_price");
            var Rental_price = float.Parse(Console.ReadLine());
            Console.WriteLine("Customer_id");
            var Customer_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bicycle_id");
            var Bicycle_id = Convert.ToInt32(Console.ReadLine());


            try
            {
                var NewBooking_detail = new Booking_detail()
                {
                    Return_due_date = Return_due_date,
                    Rental_price = Rental_price,
                    Customer_id = Customer_id,
                    Bicycle_id = Bicycle_id
                };
                _bicycleRentalDbContext.Booking_details
                    .Add(NewBooking_detail);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New customer added successfully!");
                Console.WriteLine($"Customer_id: {NewBooking_detail.Return_due_date}");
                Console.WriteLine($"Customer_name: {NewBooking_detail.Rental_price}");
                Console.WriteLine($"Gender: {NewBooking_detail.Customer_id}");
                Console.WriteLine($"Phone_number: {NewBooking_detail.Bicycle_id}");
                
            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }
    }
}
