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
            if(Vehicles.Count > 0)
            {
                foreach (ArialVehicle a in Vehicles)
                {
                    TakeOff(a);
                }

                return null;
            }
            else
            {
                return "The airport is empty";
            }
            
            
        }

        string Land(ArialVehicle a)
        {
            Vehicles.Add(a);
            a.FlyDown(a.CurrentAltitude); //fly down to ground
            return this + " has landed at the airport.";
        }

        string Land(List<ArialVehicle> landing)
        {
            if(Vehicles.Count < MaxVehicles)
            {
                foreach(ArialVehicle a in landing)
                {
                    Land(a);
                }

                return null;
            }
            else
            {
                return "The airport is full";
            }
            
        }

        string TakeOff(ArialVehicle a)
        {
            Vehicles.Remove(a); 
            return a.TakeOff();
        }


    }
}
