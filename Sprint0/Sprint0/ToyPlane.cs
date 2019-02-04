using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    public class ToyPlane : Airplane
    {
        bool isWoundUP; 

        public new string About()
        {
            return getWindUpString() + "\n"+
                getEngineStartedString() + "\nThis " + this + 
                " has a max altitude of " + MaxAltitude + "\nIt's current altitude is " + CurrentAltitude;
        }

        public string getWindUpString()
        {
            if (isWoundUP)
            {
                return this + " is wound up.";
            }
            else
            {
                return this + " is not wound up.";
            }
            
        }

        public new void StartEngine()
        {
            if (isWoundUP)
            {
                Engine.IsStarted = true;
            }
            else
            {
                Console.WriteLine("Can't start engine until wound up!");
            }
        }

        public new string TakeOff() 
        {
            if (!isWoundUP)
            {
                return this + " can't fly, it isn't wound up!";
            }
            if (!Engine.IsStarted)
            {
                return this + " can't fly it's engine is not started.";
            }
            else 
            {
                return this + " is flying";
            }
        }

        public ToyPlane()
        {
            MaxAltitude = 50;
            isWoundUP = false;
        }

        public void UnWind()
        {
            isWoundUP = false;
        }

        public void WindUp()
        {
            isWoundUP = true;
        }

    }
}
