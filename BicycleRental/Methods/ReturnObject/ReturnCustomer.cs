using BicycleRental.Models;

namespace BicycleRental.Methods.ReturnObject
{
    public class ReturnCustomer
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public ReturnCustomer()
        {

        }

        public Customer Return_Customer(int customer_id)
        {
            try
            {
                var _customer = _bicycleRentalDbContext.Customers.Find(customer_id);

                return _customer;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
