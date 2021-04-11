﻿using BicycleRental.Models;

namespace BicycleRental.Methods.ReturnObject
{
    public class ReturnBicycle
    {
        readonly BicycleRentalDbContext _bicycleRentalDbContext = new BicycleRentalDbContext();
        public ReturnBicycle()
        {

        }

        public Bicycle Return_Bicycle(int bicycle_Id)
        {
            var _bicycle = _bicycleRentalDbContext.Bicycles.Find(bicycle_Id);

            return _bicycle;
        }
    }
}
