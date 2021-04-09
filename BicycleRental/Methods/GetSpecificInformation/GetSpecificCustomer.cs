using BicycleRental.Methods.GetAllInformation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.GetSpecificInformation
{
    public class GetSpecificCustomer
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public GetSpecificCustomer()
        {

        }
        public void GetSpecificCustomerInfo() 
        {
            var customers = new GetAllCustomers();
            Console.WriteLine($"Here are all existing customers:\n");
            customers.GetAllCustomersInfo();

            Console.WriteLine($"\nChoose specific customer to view by entering customer Id ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var customer = _bicycleRentalDbContext.Customers.Find(userInput);

            Console.Clear();

            Console.WriteLine($"Your specific customer: ");
            Console.WriteLine($"Customer_id: {customer.Customer_id}");
            Console.WriteLine($"Customer_name: {customer.Customer_name}");
            Console.WriteLine($"Gender: {customer.Gender}");
            Console.WriteLine($"Phone_number: {customer.Phone_number}");
            Console.WriteLine($"E_mail: {customer.E_mail}");

        }
    }
}
