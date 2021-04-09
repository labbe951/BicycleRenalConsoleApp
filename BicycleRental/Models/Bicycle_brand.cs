using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Models
{
    public class Bicycle_brand
    {
        
        public int Brand_id { get; set; }
        public string Bicycle_type { get; set; }
        public string Bicycle_name { get; set; }
        public bool Avilability { get; set; }
        public ICollection<Bicycle> Bicycles { get; set; }
    }
}
