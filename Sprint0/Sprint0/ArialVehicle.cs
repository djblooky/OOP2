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
        public Engine Engine { get; set; }

        public string About()
        {
            return getEngineStartedString() + "\n\tThis " + nameof(ArialVehicle) + " has a max altitude of \n\tIt's current altitude is " + CurrentAltitude;
        }

        public ArialVehicle()
        {

        }

        public void FlyDown()
        {
            if (CurrentAltitude - 1000 < 0)
            {
                //crash
            }
            else
            {
                CurrentAltitude -= 1000;
            }
        }

        public void FlyDown(int HowManyFeet)
        {
            if(CurrentAltitude - HowManyFeet < 0)
            {
                //crash
            }
            else
            {
                CurrentAltitude -= HowManyFeet;
            }
        }

        public void FlyUp()
        {
            if(CurrentAltitude + 1000 <= MaxAltitude)
            {
                CurrentAltitude += 1000;
            }  
        }

        public void FlyUp(int HowManyFeet)
        {
            if (CurrentAltitude + HowManyFeet <= MaxAltitude)
            {
                CurrentAltitude += HowManyFeet;
            }    
        }

        public string getEngineStartedString() 
        {
            if (Engine.IsStarted)
            {
                return nameof(ArialVehicle) + " engine is started\t";
            }
            else
            {
                return nameof(ArialVehicle) + " engine is not started\t";
            }
        }

        public void StartEngine()
        {
            Engine.IsStarted = true;
        }

        public void StopEngine()
        {
            Engine.IsStarted = false;
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
