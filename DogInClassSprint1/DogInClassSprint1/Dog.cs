using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogInClassSprint1
{
    public class Dog
    {
        public int Age { get; protected set; }
        public int Weight { get; protected set; }
        public string Name{ get; protected set; }
        public string BarkSound { get; protected set; }
        public int BarkCount { get; protected set; }

        public Dog()
        {
            this.Age = 1;
            this.Name = "Fido";
            this.Weight = 1;
            this.BarkCount = 0;
            this.BarkSound = "Woof";
        }

        public string Bark()
        {
            this.BarkCount++;
            return this.BarkSound;
        }

        public string Bark(int HowManyTimes)
        {
            string BarkString = "";
            for(int i=0; i < HowManyTimes; i++)
            {
                BarkString += this.Bark();
            }

            return BarkString;
        }

        public void HappyBirthday()
        {
            this.Age++;
        }

        public string About()
        {
            return $"Hello my name is {this.Name} I'm {this.Age} years old. My bark sounds like {this.BarkSound}. Ive barked {this.BarkCount} times.";
        }
    }
}
