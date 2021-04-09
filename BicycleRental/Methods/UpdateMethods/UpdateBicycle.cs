using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.GetSpecificInformation;
using BicycleRental.Methods.ReturnObject;
using BicycleRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

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

                

                var Bicycle = new GetAllBicycles();
                Bicycle.GetAllBicyclesInfo();

                Console.WriteLine("Choose bicycle to update by entering Bicycle Id: ");
                var userinput = Convert.ToInt32(Console.ReadLine());

                var getBicycle = new ReturnBicycle();
                var bicycleToUpdate = getBicycle.Return_Bicycle(userinput);

                
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
                Console.WriteLine($"Bicycle Bicycle_id: {bicycleToUpdate.Bicycle_id}");
                Console.WriteLine($"Bicycle Frame_number: {bicycleToUpdate.Frame_number}");
                Console.WriteLine($"Bicycle Brand_id: {bicycleToUpdate.Brand_id}");


            }

            catch (Exception ex)
            {

                Console.WriteLine($"You messed up! {ex}");
            }
        }
    }
}
