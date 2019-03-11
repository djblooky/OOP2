using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public abstract class Coin : ICoin
    {
        public int Year { get; set; }

        public double MonetaryValue { get; set; }

        public string Name { get; set; }

        public virtual string About()
        {
            return Name + " is from " + Year + ". It is worth $0" + MonetaryValue + ".";
                
        }
        public Coin()
        {

        }
    }
}
