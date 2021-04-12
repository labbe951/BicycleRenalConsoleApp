using BicycleRental.Models;
using System;

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

            try
            {
                Console.WriteLine("Customer_First_Name");
                var customerFirstName = Console.ReadLine();
                Console.WriteLine("Customer_Last_Name");
                var customerLastName = Console.ReadLine();
                Console.WriteLine("Gender");
                var gender = Console.ReadLine();
                Console.WriteLine("Phone_number");
                var phoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("E_mail");
                var eMail = Console.ReadLine();

                var newCustomer = new Customer()
                {
                    Customer_First_Name = customerFirstName,
                    Customer_Last_Name = customerLastName,
                    Gender = gender,
                    Phone_number = phoneNumber,
                    E_mail = eMail
                };
                _bicycleRentalDbContext.Customers
                    .Add(newCustomer);
                _bicycleRentalDbContext
                .SaveChanges();

                Console.WriteLine("New customer added successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Customer_id: {newCustomer.Customer_id}");
                Console.WriteLine($"Customer_First_Name: {newCustomer.Customer_First_Name}");
                Console.WriteLine($"Customer_Last_Name: {newCustomer.Customer_Last_Name}");
                Console.WriteLine($"Gender: {newCustomer.Gender}");
                Console.WriteLine($"Phone_number: {newCustomer.Phone_number}");
                Console.WriteLine($"E_mail: {newCustomer.E_mail}");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("");
            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }


    }
}
