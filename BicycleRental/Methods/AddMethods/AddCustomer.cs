using BicycleRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.AddMethods
{
    public class AddCustomer
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public AddCustomer()
        {

        }
       
        /// <summary>
        /// Add new Customer
        /// </summary>
        public void AddNewCustomer() 
        {

            Console.WriteLine("Customer_name");
            var Customer_name = Console.ReadLine();
            Console.WriteLine("Gender");
            var Gender = Console.ReadLine();
            Console.WriteLine("Phone_number");
            var Phone_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("E_mail");
            var E_mail = Console.ReadLine();



            try
            {
                var NewCustomer = new Customer()
                {
                    Customer_name = Customer_name,
                    Gender = Gender,
                    Phone_number = Phone_number,
                    E_mail = E_mail
                };
                _bicycleRentalDbContext.Customers
                    .Add(NewCustomer);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New customer added successfully!");
                Console.WriteLine($"Customer_id: {NewCustomer.Customer_id}");
                Console.WriteLine($"Customer_name: {NewCustomer.Customer_name}");
                Console.WriteLine($"Gender: {NewCustomer.Gender}");
                Console.WriteLine($"Phone_number: {NewCustomer.Phone_number}");
                Console.WriteLine($"E_mail: {NewCustomer.E_mail}");
                Console.WriteLine("");
            }

            catch (Exception ex )
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }

       
    }
}
