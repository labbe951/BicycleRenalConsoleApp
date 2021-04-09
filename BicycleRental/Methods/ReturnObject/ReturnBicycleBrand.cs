﻿using BicycleRental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRental.Methods.ReturnObject
{
    public class ReturnBicycleBrand
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public ReturnBicycleBrand()
        {

        }

        public Bicycle_brand Return_Bicycle(int bicycle_brand_Id)
        {
            var _bicycleBrand = _bicycleRentalDbContext.Bicycle_brands.Find(bicycle_brand_Id);

            return _bicycleBrand;
        }
    }
}
