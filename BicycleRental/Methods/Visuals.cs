using BicycleRental.Methods.AddMethods;
using BicycleRental.Methods.DeleteMethods;
using BicycleRental.Methods.GetAllInformation;
using BicycleRental.Methods.GetSpecificInformation;
using BicycleRental.Methods.UpdateMethods;
using BicycleRental.Methods.GetMultiInfo;
using Figgle;
using System;
using BicycleRental.Methods.StartupSeed;
using BicycleRental.Methods.GetFiltered;

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
            var createSeed = new CreateSeed();

            Console.Clear();
            Console.WriteLine(FiggleFonts.Slant.Render("Main Menu"));
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("1: Alter information");
            Console.WriteLine("2: Show information");
            Console.WriteLine("3: Exit Application");
            Console.WriteLine("9: Seed information to database");
            Console.WriteLine("-------------------------");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    AlterInformation();
                    break;
                case "2":
                    ShowInformation();
                    break;
                case "9":
                    createSeed.StartUpData();
                    ReturnToMainMenu();
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
            Console.WriteLine("4: Return to Main Menu");

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
                case "4":
                    MainMenu();
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
            var customer = new AddCustomer();
            var bicycle = new AddBicycle();
            var bookingDetail = new AddBooking_detail();
            var bicycleBrand = new AddBicycle_brand();

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
                    customer.AddNewCustomer();
                    ReturnToMainMenu();
                    break;
                case "2":
                    bicycle.AddNewBicycle();
                    ReturnToMainMenu();
                    break;
                case "3":
                    bookingDetail.AddNewBooking_detail();
                    ReturnToMainMenu();
                    break;
                case "4":
                    bicycleBrand.AddNewBicycleBrand();
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
            var customer = new UpdateCustomer();
            var bicycle = new UpdateBicycle();
            var bookingDetail = new UpdateBookingDetails();
            var bicycleBrand = new UpdateBicycleBrand();

            Console.Clear();
            Console.WriteLine("1: Update Customer");
            Console.WriteLine("2: Update Bicycle");
            Console.WriteLine("3: Update Booking Detail");
            Console.WriteLine("4: Update Bicycle Brand");


            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    customer.UpdateExistingCustomer();
                    ReturnToMainMenu();
                    break;
                case "2":
                    bicycle.UpdateExistingBicycle();
                    ReturnToMainMenu();
                    break;
                case "3":
                    bookingDetail.UpdateExistingBookingDetails();
                    ReturnToMainMenu();
                    break;
                case "4":
                    bicycleBrand.UpdateExistingBicycleBrand();
                    ReturnToMainMenu();
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
            var customer = new DeleteCustomer();
            var bicycle = new DeleteBicycle();
            var bookingDetail = new DeleteBooking_detail();
            var bicycleBrand = new DeleteBicycle_brand();
            
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
                    customer.DeleteExistingCustomer();
                    ReturnToMainMenu();
                    break;
                case "2":
                    bicycle.DeleteExistingBicycle();
                    ReturnToMainMenu();
                    break;
                case "3":
                    bookingDetail.DeleteExistingCustomer();
                    ReturnToMainMenu();
                    break;
                case "4":
                    bicycleBrand.DeleteExistingBicycleBrand();
                    ReturnToMainMenu();
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
            var multi = new GetCustomerWithBicycle();

            Console.Clear();
            Console.WriteLine("1: Show all information");
            Console.WriteLine("2: Show specific information");
            Console.WriteLine("3: Customer with Bicycle");

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
                case "3":
                    multi.GetCustomerWithBookingAndBicycle();
                    ReturnToMainMenu();
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
            var bicycles = new GetAllBicycles();
            var customers = new GetAllCustomers();
            var bicycleBrands = new GetAllBicycleBrands();
            var filteredCustomer = new GetFilteredCustomers();

            Console.Clear();
            Console.WriteLine("1: Show all Bicycles");
            Console.WriteLine("2: Show all Customers");
            Console.WriteLine("3: Show all Bicycle Brands");
            Console.WriteLine("4: Show all Customers who's first name starts with the letter 'A'");


            Console.WriteLine("");

            var userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    bicycles.GetAllBicyclesInfo();
                    ReturnToMainMenu();
                    break;
                case "2":
                    customers.GetAllCustomersInfo();
                    ReturnToMainMenu();
                    break;
                case "3":
                    bicycleBrands.GetAllBicycleBrandsInfo();
                    ReturnToMainMenu();
                    break;
                case "4":
                    filteredCustomer.GetFilteredCustomersInfo();
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
            var customer = new GetSpecificCustomer();
            var bicycle = new GetSpecificBicycle();
            var bicycleBrand = new GetSpecificBicycleBrand();
            var bookingDetail = new GetSpecificBookingDetails();

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
                    bicycle.GetSpecificBicycleInfo();
                    ReturnToMainMenu();
                    break;
                case "2":
                    customer.GetSpecificCustomerInfo();
                    ReturnToMainMenu();
                    break;
                case "3":
                    bookingDetail.GetSpecificBookingDetailsInfo();
                    ReturnToMainMenu();
                    break;
                case "4":
                    bicycleBrand.GetSpecificBicycleBrandInfo();
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



