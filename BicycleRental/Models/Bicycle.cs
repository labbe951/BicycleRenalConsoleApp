using System.Collections.Generic;

namespace BicycleRental.Models
{
    public class Bicycle
    {

        public int Bicycle_id { get; set; }
        public int Frame_number { get; set; }
        public int Brand_id { get; set; }
        public Bicycle_brand Bicycle_brand { get; set; }
        public ICollection<Booking_detail> Booking_Details { get; set; }
    }
}
