using BicycleRental.Methods.GetAllInformation;
using System;

namespace BicycleRental.Methods.GetSpecificInformation
{
    public class GetSpecificCustomer
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public GetSpecificCustomer()
        {

        }

        /// <summary>
        /// Get specific customer info 
        /// </summary>
        public void GetSpecificCustomerInfo()
        {
            try
            {
                var customers = new GetAllCustomers();
                Console.WriteLine($"Here are all existing customers:\n");
                customers.GetAllCustomersInfo();

                Console.WriteLine($"\nChoose specific customer to view by entering customer Id ");
                var userInput = Convert.ToInt32(Console.ReadLine());
                var customer = _bicycleRentalDbContext.Customers.Find(userInput);

                if (customer == null)
                {
                    Console.WriteLine("No customer was found.."); 
                    Visuals.ReturnToMainMenu();
                }

                Console.Clear();

                Console.WriteLine($"Your specific customer: ");
                Console.WriteLine($"Customer_id: {customer.Customer_id}");
                Console.WriteLine($"Customer_First_Name: {customer.Customer_First_Name}");
                Console.WriteLine($"Customer_Last_Name: {customer.Customer_Last_Name}");
                Console.WriteLine($"Gender: {customer.Gender}");
                Console.WriteLine($"Phone_number: {customer.Phone_number}");
                Console.WriteLine($"E_mail: {customer.E_mail}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }

        }
    }
}
