using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    public abstract class ArialVehicle
    {
        public int CurrentAltitude { get; set; }
        public int MaxAltitude { get; set; }
        bool IsFlying { get; set; }
        Engine Engine { get; set; }

        public string About()
        {
            string EngineStatus;
            if (Engine.IsStarted)
            {
                EngineStatus = nameof(ArialVehicle) + " engine is started\n\t";
            }
            else
            {
                EngineStatus = nameof(ArialVehicle) + " engine is not started\n\t";
            }

            return EngineStatus + "\n\tThis " + nameof(ArialVehicle) + " has a max altitude of \n\tIt's current altitude is " + CurrentAltitude;
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
            CurrentAltitude += 1000;
        }

        public void FlyUp(int HowManyFeet)
        {
            CurrentAltitude += HowManyFeet;
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
            if (Engine.IsStarted) 
            {
                return nameof(Airplane) + " can't fly it's engine is not started.";
            }
            else
            {
                return nameof(Airplane) + " is flying";
            }
        }
    }
}
