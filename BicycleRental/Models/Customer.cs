using System.Collections.Generic;

namespace BicycleRental.Models
{
    public class Customer
    {

        public int Customer_id { get; set; }
        public string Customer_First_Name { get; set; }
        public string Customer_Last_Name { get; set; }
        public string Gender { get; set; }
        public int Phone_number { get; set; }
        public string E_mail { get; set; }
        public ICollection<Booking_detail> Booking_details { get; set; }

    }
}
