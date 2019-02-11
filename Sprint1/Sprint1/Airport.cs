using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    class Airport
    {
        private int MaxVehicles;
        private List<ArialVehicle> Vehicles = new List<ArialVehicle>();

        public string AirportCode { get; protected set; }

        public Airport(string Code)
        {
            AirportCode = Code;
        }

        public Airport(string Code, int MaxVehicles)
        {
            AirportCode = Code;
            this.MaxVehicles = MaxVehicles;
        }

        string AllTakeOff()
        {
            return "";
        }

        string Land(ArialVehicle a)
        {
            return "";
        }

        string Land(List<ArialVehicle> landing)
        {
            return "";
        }

        string TakeOff(ArialVehicle a)
        {
            return "";
        }


    }
}
