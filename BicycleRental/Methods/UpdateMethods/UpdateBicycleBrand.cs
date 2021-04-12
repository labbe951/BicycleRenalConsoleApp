using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;

namespace BicycleRental.Methods.UpdateMethods
{
    public class UpdateBicycleBrand
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public UpdateBicycleBrand()
        {

        }

        public void UpdateExistingBicycleBrand() 
        {

            try
            {

                var bicycleBrand = new GetAllBicycleBrands();
                bicycleBrand.GetAllBicycleBrandsInfo();

                Console.WriteLine("Choose bicycle brand to update by entering Bicycle Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBicycleBrand = new ReturnBicycleBrand();
                var bicycleBrandToUpdate = getBicycleBrand.Return_BicycleBrand(userinput);

                if (bicycleBrandToUpdate == null)
                {
                    Console.WriteLine("No Bicycle Brand was found..");
                    Visuals.ReturnToMainMenu();
                }

                Console.WriteLine("Change bicycle brand information");
                Console.WriteLine("");
                Console.WriteLine("Update Bicycle type");
                bicycleBrandToUpdate.Bicycle_type = Console.ReadLine();
                Console.WriteLine("Update Bicycle name");
                bicycleBrandToUpdate.Bicycle_name = Console.ReadLine();
                Console.WriteLine("Update Avilability");
                bicycleBrandToUpdate.Avilability = Convert.ToBoolean(Console.ReadLine());



                _bicycleRentalDbContext
                    .Bicycle_brands
                    .Update(bicycleBrandToUpdate);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine("Existing bicicle brand: updated successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Bicycle brand Bicycle_type: {bicycleBrandToUpdate.Bicycle_type}");
                Console.WriteLine($"Bicycle brand Bicycle_name: {bicycleBrandToUpdate.Bicycle_name}");
                Console.WriteLine($"Bicycle brand Avilability: {bicycleBrandToUpdate.Avilability}");
                Console.WriteLine("---------------------------------------");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
