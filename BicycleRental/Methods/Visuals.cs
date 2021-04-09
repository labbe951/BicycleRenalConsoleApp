using BicycleRental.Methods.AddMethods;
using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.GetSpecificInformation;
using BicycleRental.Methods.UpdateMethods;
using BicycleRental.Models;
using Figgle;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods
{

    public class Visuals
    {
        public Visuals()
        {
            
        }

        public static void Header() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(FiggleFonts.Slant.Render("Bicycle Rental"));

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to enter my Rental Store...");
            Console.ReadLine();

        }

        /// <summary>
        /// This is the Main Menu
        /// </summary>
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Main menu");
            Console.WriteLine("1: Alter information");
            Console.WriteLine("2: Show information");
            Console.WriteLine("3: Exit Application");
        
            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    AlterInformation();
                    break;
                case "2":
                    ShowInformation();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    MainMenu();
                    break;
            }
        }

        /// <summary>
        /// Choose this to enter the alter info menu
        /// </summary>
        public static void AlterInformation() 
        {
            Console.Clear();
            Console.WriteLine("1: Add information");
            Console.WriteLine("2: Update information");
            Console.WriteLine("3: Delete infromation");
            
            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    AddInformation();
                    break;
                case "2":
                    UpdateInformation();
                    break;
                case "3":
                    DeleteInformation();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    AlterInformation();
                    break;
            }
        }

        /// <summary>
        /// Choose this to enter the Add Information menu
        /// </summary>
        public static void AddInformation()
        {
            var Customer = new AddCustomer();
            var Bicycle = new AddBicycle();
            var Bicycle_brand = new AddBicycle_brand();
            var BookingDetail = new AddBooking_detail();

            Console.Clear();
            Console.WriteLine("1: Add Customer");
            Console.WriteLine("2: Add Bicycle");
            Console.WriteLine("3: Add Booking_detail");
            Console.WriteLine("4: Add Bicycle_brand");
            Console.WriteLine("5: Return to Main Menu");

            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Customer.AddNewCustomer();
                    ReturnToMainMenu();
                    break;
                case "2":
                     Bicycle.AddNewBicycle();
                    ReturnToMainMenu();
                    break;
                case "3":
                    BookingDetail.AddNewBooking_detail();
                    ReturnToMainMenu();
                    break;
                case "4":
                    Bicycle_brand.AddNewBicycleBrand();
                    ReturnToMainMenu();
                    break;
                case "5":
                    MainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    AddInformation();
                    break;
            }
        }

        /// <summary>
        /// Choose this to enter the Update Information menu
        /// </summary>
        public static void UpdateInformation()
        {
            var Bicycle = new UpdateBicycle();

            Console.Clear();
            Console.WriteLine("1: Update Customer");
            Console.WriteLine("2: Update Bicycle");
            Console.WriteLine("3: Update Booking_detail");
            Console.WriteLine("4: Update Bicycle_brand");


            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    //Update Customer();
                    break;
                case "2":
                    Bicycle.UpdateExistingBicycle();
                    break;
                case "3":
                    //Update Booking_detail();
                    break;
                case "4":
                    //Update Bicycle_brand();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    UpdateInformation();
                    break;
            }
        }

        /// <summary>
        /// Choose this to enter the Delete Information menu
        /// </summary>
        public static void DeleteInformation()
        {
            Console.Clear();
            Console.WriteLine("1: Delete Customer");
            Console.WriteLine("2: Delete Bicycle");
            Console.WriteLine("3: Delete Booking_detail");
            Console.WriteLine("4: Delete Bicycle_brand");


            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    //Delete Customer();
                    break;
                case "2":
                    //Delete Bicycle();
                    break;
                case "3":
                    //Delete Booking_detail();
                    break;
                case "4":
                    //Delete Bicycle_brand();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    DeleteInformation();
                    break;
            }
        }

        /// <summary>
        /// Choose this to enter the Show Information menu
        /// </summary>
        public static void ShowInformation()
        {
            Console.Clear();
            Console.WriteLine("1: Show all information");
            Console.WriteLine("2: Show specific information");
            

            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    ShowAllInformation();
                    break;
                case "2":
                    ShowSpecificInformation();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    ShowInformation();
                    break;

            }
        }

        /// <summary>
        /// Choose this to enter the Show All Information menu
        /// </summary>
        public static void ShowAllInformation()
        {
            var Bicycles = new GetAllBicycles();
            var Customers = new GetAllCustomers();
            var BicycleBrands = new GetAllBicycleBrands();

            Console.Clear();
            Console.WriteLine("1: Show all Bicycles");
            Console.WriteLine("2: Show all Customers");
            Console.WriteLine("3: Show all Bicycle Brands");


            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Bicycles.GetAllBicyclesInfo();
                    ReturnToMainMenu();
                    break;
                case "2":
                    Customers.GetAllCustomersInfo();
                    ReturnToMainMenu();
                    break;
                case "3":
                    BicycleBrands.GetAllBicycleBrandsInfo();
                    ReturnToMainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    ShowAllInformation();
                    break;
            }
        }

        /// <summary>
        /// Choose this to enter the Show Specific Information menu
        /// </summary>
        public static void ShowSpecificInformation()
        {
            var Customer = new GetSpecificCustomer();
            var Bicycle = new GetSpecificBicycle();
            var BicycleBrand = new GetSpecificBicycleBrand();

            Console.Clear();
            Console.WriteLine("1: Show specific Bicycle");
            Console.WriteLine("2: Show specific Customer");
            Console.WriteLine("3: Show specific Booking_detail");
            Console.WriteLine("4: Show specific Bicycle_brand");


            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    Bicycle.GetSpecificBicycleInfo();
                    ReturnToMainMenu();
                    break;
                case "2":
                    Customer.GetSpecificCustomerInfo();
                    ReturnToMainMenu();
                    break;
                case "3":
                    //ShowSpecific Booking_detail();
                    break;
                case "4":
                    BicycleBrand.GetSpecificBicycleBrandInfo();
                    ReturnToMainMenu();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Input does not exist!.. Press any key except the one you pressed to get here!.. try again!.. ");
                    Console.ReadKey();
                    ShowSpecificInformation();
                    break;

            }
        }

        public static void ReturnToMainMenu() 
        {
            Console.WriteLine("");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
            MainMenu();
        }

    }

}



