using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
{
    public abstract class ArialVehicle
    {
        public int CurrentAltitude { get; protected set; }
        public int MaxAltitude { get; protected set; }
        public bool IsFlying { get; set; }
        public Engine Engine { get; protected set; }

        public string About()
        {
            return getEngineStartedString() + "\nThis " + this + " has a max altitude of " + MaxAltitude +  "\nIt's current altitude is " + CurrentAltitude;
        }

        public ArialVehicle()
        {
            CurrentAltitude = 0;
            IsFlying = false;
            Engine = new Engine();
        }

        public void FlyDown()
        {
            FlyDown(1000);
        }

        public void FlyDown(int HowManyFeet)
        {
            if(CurrentAltitude - HowManyFeet < 0)
            {
                Console.WriteLine(this + " flew down too far and crashed");
            }
            else
            {
                CurrentAltitude -= HowManyFeet;
            }
        }

        public void FlyUp()
        {
            int defaultFly;
            if(this is ToyPlane)
            {
                defaultFly = 10;
            }
            else
            {
                defaultFly = 1000;
            }

           FlyUp(defaultFly);
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
                return this + " engine is started\t";
            }
            else
            {
                return this + " engine is not started\t";
            }
        }

        public virtual void StartEngine()
        {
            Engine.IsStarted = true;
        }

        public void StopEngine()
        {
            Engine.IsStarted = false;
        }

        public virtual string TakeOff()
        {
            if (!Engine.IsStarted) 
            {
                return this + " can't fly it's engine is not started.";
            }
            else
            {
                return this + " is flying";
            }
        }
    }
}
