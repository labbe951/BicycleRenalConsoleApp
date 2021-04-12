using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.ReturnObject;
using System;

namespace BicycleRental.Methods.UpdateMethods
{
    class UpdateBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();

        public UpdateBicycle()
        {

        }


        public void UpdateExistingBicycle()
        {


            try
            {

                var bicycle = new GetAllBicycles();
                bicycle.GetAllBicyclesInfo();

                Console.WriteLine("Choose bicycle to update by entering Bicycle Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBicycle = new ReturnBicycle();
                var bicycleToUpdate = getBicycle.Return_Bicycle(userinput);

                if (bicycleToUpdate == null)
                {
                    Console.WriteLine("No bicycle was found..");
                    Visuals.ReturnToMainMenu();
                }

                Console.WriteLine("Change bicycle information");
                Console.WriteLine("");
                Console.WriteLine("Update Frame number");
                bicycleToUpdate.Frame_number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Update Brand id");
                bicycleToUpdate.Brand_id = Convert.ToInt32(Console.ReadLine());


                _bicycleRentalDbContext
                    .Bicycles
                    .Update(bicycleToUpdate);

                _bicycleRentalDbContext
                        .SaveChanges();

                Console.WriteLine("Existing bicicle updated successfully!");
                Console.WriteLine("");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"Bicycle Bicycle_id: {bicycleToUpdate.Bicycle_id}");
                Console.WriteLine($"Bicycle Frame_number: {bicycleToUpdate.Frame_number}");
                Console.WriteLine($"Bicycle Brand_id: {bicycleToUpdate.Brand_id}");
                Console.WriteLine("---------------------------------------");

            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
