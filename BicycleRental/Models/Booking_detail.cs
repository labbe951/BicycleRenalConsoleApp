using BicycleRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental
{
    public class Booking_detail
    {
        
        public int Booking_id { get; set; }
        public DateTime Booking_date { get; set; }
        public DateTime Return_due_date { get; set; }
        public float Rental_price { get; set; }
        public int Customer_id { get; set; }
        public int Bicycle_id { get; set; }

        public Customer Customer { get; set; }
        public Bicycle Bicycle { get; set; }

    }
}
