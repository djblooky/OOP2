using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    public abstract class ArialVehicle
    {
        int CurrentAltitude { get; set; }
        int MaxAltitude { get; set; }
        bool IsFlying { get; set; }
        Engine Engine { get; set; }

        public string About()
        {
            /* Output AirplaneAbout:
             * This OOPFlyingVehicle.Airplane has a max altitude of 41000 ft.
             * It's current altitude is 0 ft.
             * OOPFlyingVehicleMidterm.Airplane engine is not started
             */
            return "\n\tThis " ;
        }

        public ArialVehicle()
        {

        }

        public void FlyDown()
        {

        }

        public void FlyDown(int HowManyFeet)
        {

        }

        public void FlyUp()
        {

        }

        public void FlyUp(int HowManyFeet)
        {

        }

        public string getEngineStartedString() 
        {
            return "";
        }

        public void StartEngine()
        {

        }

        public void StopEngine()
        {

        }

        public string TakeOff()
        {
            return "";
        }
    }
}
