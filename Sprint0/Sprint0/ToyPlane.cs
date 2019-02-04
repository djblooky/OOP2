using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    public class ToyPlane : Airplane
    {
        bool isWoundUP = false; 

        public new string About()
        {
            return getWindUpString();
            //add other about info?
        }

        public string getWindUpString()
        {
            if (isWoundUP)
            {
                return nameof(ToyPlane) + " is wound up.";
            }
            else
            {
                return nameof(ToyPlane) + " is not wound up.";
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
                Console.WriteLine("Not wound up, engine is not started");
            }
        }

        public new string TakeOff()
        {
            return "";
        }

        public ToyPlane()
        {
            MaxAltitude = 50;
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
