using System;
using System.Collections.Generic;
using System.Text;

namespace CarInventoryDemo
{
    public abstract class Vehicle
    {
        public string VIN { get; set; }

        public string LicensePlate { get; set; }

        public abstract int Wheels { get; }

        public abstract int MaxPassengers { get; }

        public abstract string GetDescription();
    }

}
