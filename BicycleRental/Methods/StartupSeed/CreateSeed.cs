using BicycleRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.StartupSeed
{
    public class CreateSeed
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public CreateSeed()
        {

        }
        /// <summary>
        /// Seeds data when used
        /// </summary>
        public void StartUpData() 
        {
            var customer = new Customer { Customer_First_Name = "Alexander", Customer_Last_Name = "Haglund", Gender = "Male", Phone_number = 9009111, E_mail = "Haglund.Alexander@hotmail.com" };
            var customer1 = new Customer { Customer_First_Name = "Mel", Customer_Last_Name = "Gibson", Gender = "Male", Phone_number = 7010202, E_mail = "Riggs.Martin@lethalWeapon.com" };
            var customer2 = new Customer { Customer_First_Name = "Miriam", Customer_Last_Name = "Bryant", Gender = "Female", Phone_number = 1032111, E_mail = "Bryant.Miriam@sverige.nu" };
            var customer3 = new Customer { Customer_First_Name = "Tobias", Customer_Last_Name = "Nilsson", Gender = "Male", Phone_number = 1212120, E_mail = "Nilsson.Tobias@hotmail.com" };
            var customer4 = new Customer { Customer_First_Name = "Elin", Customer_Last_Name = "Rosblad", Gender = "Female", Phone_number = 2024111, E_mail = "Rosblad.Elin@hotmail.com" };
            var customer5 = new Customer { Customer_First_Name = "Maria", Customer_Last_Name = "Bergsten", Gender = "Female", Phone_number = 1122334, E_mail = "Bergsten.Maria@hotmail.com" };

            var bicycleBrand = new Bicycle_brand { Bicycle_type = "BMX", Bicycle_name = "Tricky Ramp Bike", Avilability = true };
            var bicycleBrand1 = new Bicycle_brand { Bicycle_type = "Mountain Bike", Bicycle_name = "Down Hill 2000", Avilability = true };
            var bicycleBrand2 = new Bicycle_brand { Bicycle_type = "Road bike", Bicycle_name = "Smooth Rider", Avilability = true };
            var bicycleBrand3 = new Bicycle_brand { Bicycle_type = "Folding bikes", Bicycle_name = "Smart Bike", Avilability = true };

            var bicycle = new Bicycle { Frame_number = 1313, Brand_id = 1 };
            var bicycle1 = new Bicycle { Frame_number = 2121, Brand_id = 1 };
            var bicycle2 = new Bicycle { Frame_number = 1111, Brand_id = 1 };
            var bicycle3 = new Bicycle { Frame_number = 3131, Brand_id = 2 };
            var bicycle4 = new Bicycle { Frame_number = 6262, Brand_id = 2 };
            var bicycle5 = new Bicycle { Frame_number = 5757, Brand_id = 3 };
            var bicycle6 = new Bicycle { Frame_number = 7811, Brand_id = 3 };
            var bicycle7 = new Bicycle { Frame_number = 1100, Brand_id = 4 };
            var bicycle8 = new Bicycle { Frame_number = 8811, Brand_id = 4 };

            var bookingDetail = new Booking_detail { Booking_date = DateTime.Now, Return_due_date = DateTime.Now.AddDays(12), Rental_price = 1200, Customer_id = 1, Bicycle_id = 2 };
            var bookingDetail1 = new Booking_detail { Booking_date = DateTime.Now, Return_due_date = DateTime.Now.AddDays(10), Rental_price = 999, Customer_id = 2, Bicycle_id = 1 };
            var bookingDetail2 = new Booking_detail { Booking_date = DateTime.Now, Return_due_date = DateTime.Now.AddDays(20), Rental_price = 2000, Customer_id = 3, Bicycle_id = 3 };
            var bookingDetail3 = new Booking_detail { Booking_date = DateTime.Now, Return_due_date = DateTime.Now.AddDays(5), Rental_price = 79, Customer_id = 4, Bicycle_id = 2 };
            var bookingDetail4 = new Booking_detail { Booking_date = DateTime.Now, Return_due_date = DateTime.Now.AddDays(8), Rental_price = 88, Customer_id = 5, Bicycle_id = 4 };
            var bookingDetail5 = new Booking_detail { Booking_date = DateTime.Now, Return_due_date = DateTime.Now.AddDays(4), Rental_price = 49, Customer_id = 6, Bicycle_id = 4 };

            var databaseOwner = new DatabaseOwner { OwnersFirstName = "Pontus", OwnersLastName = "Haglund"};

            _bicycleRentalDbContext.Customers.Add(customer);
            _bicycleRentalDbContext.Customers.Add(customer1);
            _bicycleRentalDbContext.Customers.Add(customer2);
            _bicycleRentalDbContext.Customers.Add(customer3);
            _bicycleRentalDbContext.Customers.Add(customer4);
            _bicycleRentalDbContext.Customers.Add(customer5);
            _bicycleRentalDbContext.SaveChanges();

            _bicycleRentalDbContext.Bicycle_brands.Add(bicycleBrand);
            _bicycleRentalDbContext.Bicycle_brands.Add(bicycleBrand1);
            _bicycleRentalDbContext.Bicycle_brands.Add(bicycleBrand2);
            _bicycleRentalDbContext.Bicycle_brands.Add(bicycleBrand3);
            _bicycleRentalDbContext.SaveChanges();

            _bicycleRentalDbContext.Bicycles.Add(bicycle);
            _bicycleRentalDbContext.Bicycles.Add(bicycle1);
            _bicycleRentalDbContext.Bicycles.Add(bicycle2);
            _bicycleRentalDbContext.Bicycles.Add(bicycle3);
            _bicycleRentalDbContext.Bicycles.Add(bicycle4);
            _bicycleRentalDbContext.Bicycles.Add(bicycle5);
            _bicycleRentalDbContext.Bicycles.Add(bicycle6);
            _bicycleRentalDbContext.Bicycles.Add(bicycle7);
            _bicycleRentalDbContext.Bicycles.Add(bicycle8);
            _bicycleRentalDbContext.SaveChanges();

            _bicycleRentalDbContext.Booking_details.Add(bookingDetail);
            _bicycleRentalDbContext.Booking_details.Add(bookingDetail1);
            _bicycleRentalDbContext.Booking_details.Add(bookingDetail2);
            _bicycleRentalDbContext.Booking_details.Add(bookingDetail3);
            _bicycleRentalDbContext.Booking_details.Add(bookingDetail4);
            _bicycleRentalDbContext.Booking_details.Add(bookingDetail5);
            _bicycleRentalDbContext.SaveChanges();

            _bicycleRentalDbContext.DatabaseOwners.Add(databaseOwner);
            _bicycleRentalDbContext.SaveChanges();

            Console.WriteLine("Database filled with information successfully");

        }
    }
}
