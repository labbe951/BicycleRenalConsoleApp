using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.DeleteMethods
{
    public class DeleteBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public DeleteBicycle()
        {

        }

        public void DeleteExistingBicycle()
        {
            try
            {

                var bicycle = new GetAllBicycles();
                bicycle.GetAllBicyclesInfo();

                Console.WriteLine("Choose Bicycle to delete by entering Bicycle Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBicycle = new ReturnBicycle();
                var bicycleToDelete = getBicycle.Return_Bicycle(userinput);

                if (bicycleToDelete == null)
                {
                    Console.WriteLine("No bicycle was found..");
                    Visuals.ReturnToMainMenu();
                }

                _bicycleRentalDbContext
                    .Bicycles
                    .Remove(bicycleToDelete);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine($"Existing Bicycles with Bicycle Id: {bicycleToDelete.Bicycle_id} deleted successfully!");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
