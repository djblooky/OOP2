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
            
            if (Vehicles.Count < MaxVehicles) //airport is not full
            {
                Vehicles.Add(a);
                a.IsFlying = false;
                a.FlyDown(a.CurrentAltitude); //fly down to ground
            }
            else
            {
                return "The airport is full";
            }

            return this + " has landed at the airport.";
        }

        string Land(List<ArialVehicle> landing)
        {
            foreach (ArialVehicle a in landing)
            {
                Land(a);
            }

            return "Landed all vehicles";
  
        }

        string TakeOff(ArialVehicle a)
        {
            Vehicles.Remove(a); 
            return a.TakeOff();
        }

    }
}
