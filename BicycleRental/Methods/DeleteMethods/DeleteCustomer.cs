using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.DeleteMethods
{
    public class DeleteCustomer
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public DeleteCustomer()
        {

        }

        public void DeleteExistingCustomer()
        {
            try
            {

                var customer = new GetAllCustomers();
                customer.GetAllCustomersInfo();

                Console.WriteLine("Choose Customer to delete by entering Customer Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getCustomer = new ReturnCustomer();
                var customerToDelete = getCustomer.Return_Customer(userinput);

                _bicycleRentalDbContext
                    .Customers
                    .Remove(customerToDelete);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine($"Existing customer with customer id: {customerToDelete.Customer_id} deleted successfully!");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
