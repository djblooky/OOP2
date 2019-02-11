using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInClassSprint1
{
    public class Mammal
    {
        public int Age { get; protected set; }
        public int Weight { get; set; }
        public string Name { get; protected set; }
        public string Sound { get; protected set; }
        public int soundCount { get; protected set; }

        public char soundSplit = ',';

        public Mammal()
        {
           
        }

        public void HappyBirthday()
        {
            this.Age++;
        }

        public string About()
        {
            return String.Empty;
        }

        public string Sound()
        {
            this.soundCount++;
            return this.Sound;
        }

        public string MakeSound(int HowManyTimes)
        {
            string soundString = "";
            for (int i = 0; i < HowManyTimes; i++)
            {
                soundString += this.Sound() + soundSplit;
            }

            return soundString;
        }
    }
}
