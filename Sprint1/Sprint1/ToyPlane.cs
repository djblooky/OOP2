using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint1
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

        public override void StartEngine()
        {
            if (isWoundUP)
            {
                base.StartEngine();
            }
            else
            {
                Console.WriteLine("Can't start engine until wound up!");
            }
        }

        public override string TakeOff() 
        {
            if (!isWoundUP)
            {
                return this + " can't fly, it isn't wound up!";
            }

             return base.TakeOff();
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
