﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarInventoryDemo
{
    public class Truck : Vehicle
    {
        public Truck(string vin, string license)
        {
            VIN = vin;
            LicensePlate = license;
        }

        public Truck()
        {
        }

        private int wheels = 4;
        public override int Wheels
        {
            get { return wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 3;
            }
        }

        public override string ToString()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN " + VIN;
        }

        public override string GetDescription()
        {
            return "Truck License Plate: " + LicensePlate +
                " VIN " + VIN + " Wheels: " + wheels + " Passengers: " + MaxPassengers; ;
        }
    }

}
