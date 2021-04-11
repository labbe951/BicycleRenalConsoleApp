using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.DeleteMethods
{
    public class DeleteBicycle_brand
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public DeleteBicycle_brand()
        {

        }

        public void DeleteExistingBicycleBrand()
        {
            try
            {

                var bicycleBrand = new GetAllBicycleBrands();
                bicycleBrand.GetAllBicycleBrandsInfo();

                Console.WriteLine("Choose Bicycle Brand to delete by entering Brand Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBicycleBrand = new ReturnBicycleBrand();
                var bicycleBrandToDelete = getBicycleBrand.Return_BicycleBrand(userinput);

                _bicycleRentalDbContext
                    .Bicycle_brands
                    .Remove(bicycleBrandToDelete);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine($"Existing customer with customer id {bicycleBrandToDelete.Brand_id} deleted successfully!");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
