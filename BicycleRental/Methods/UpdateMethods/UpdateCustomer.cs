using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;

namespace BicycleRental.Methods.UpdateMethods
{
    public class UpdateCustomer
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public UpdateCustomer()
        {

        }

        public void UpdateExistingCustomer() 
        {
            try
            {

                var customer = new GetAllCustomers();
                customer.GetAllCustomersInfo();

                Console.WriteLine("Choose Customer to update by entering Customer Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getCustomer = new ReturnCustomer();
                var customerToUpdate = getCustomer.Return_Customer(userinput);

                if (customerToUpdate == null)
                {
                    Console.WriteLine("No customer was found..");
                    Visuals.ReturnToMainMenu();
                }

                Console.WriteLine("Change Customer information");
                Console.WriteLine("");
                Console.WriteLine("Update Customer_First_Name");
                customerToUpdate.Customer_First_Name = Console.ReadLine();
                Console.WriteLine("Update Customer_Last_Name");
                customerToUpdate.Customer_Last_Name = Console.ReadLine();
                Console.WriteLine("Update Gender");
                customerToUpdate.Gender = Console.ReadLine();
                Console.WriteLine("Phone_number");
                customerToUpdate.Phone_number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Update E_mail");
                customerToUpdate.E_mail = Console.ReadLine();

                _bicycleRentalDbContext
                    .Customers
                    .Update(customerToUpdate);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine("Existing Customer updated successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Customer Customer_First_Name: {customerToUpdate.Customer_First_Name}");
                Console.WriteLine($"Customer Customer_Last_Name: {customerToUpdate.Customer_Last_Name}");
                Console.WriteLine($"Customer Gender: {customerToUpdate.Gender}");
                Console.WriteLine($"Customer Phone_number: {customerToUpdate.Phone_number}");
                Console.WriteLine($"Customer E_mail: {customerToUpdate.E_mail}");
                Console.WriteLine("---------------------------------------");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
