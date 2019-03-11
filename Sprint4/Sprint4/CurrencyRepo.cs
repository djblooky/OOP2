using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }

        public string About()
        {
            return "The currency repo contains " + GetCoinCount().ToString() + " coins totaling $" + TotalValue().ToString();
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        public ICurrencyRepo CreateChange(double Amount)
        {
            while(TotalValue() < Amount) //while enough change hasn't been made
            {
                if(Amount >= 1)
                {
                    Coins.Add(new DollarCoin());
                    Amount -= 1;
                }
                else if(Amount >= 0.5)
                {
                    Coins.Add(new HalfDollarCoin());
                    Amount -= 0.5;
                }
                else if(Amount >= 0.25)
                {
                    Coins.Add(new Quarter());
                    Amount -= 0.25;
                }
                else if(Amount >= 0.10)
                {
                    Coins.Add(new Dime());
                    Amount -= 0.10;
                }
                else if(Amount >= 0.05)
                {
                    Coins.Add(new Nickel());
                    Amount -= 0.05;
                }
                else if(Amount >= 0.01)
                {
                    Coins.Add(new Penny());
                    Amount -= 0.01;
                }
            }

            return this;
        }

     /* public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            return MakeChange(AmountTendered) + ;
        } */

        public ICoin RemoveCoin(ICoin c)
        {
            if (Coins.Contains(c))
            {
                Coins.Remove(c);
            }

            return c; //why does this return something?
        }

        public double TotalValue()
        {
            double total = 0;

            foreach(Coin c in Coins)
            {
                total += c.MonetaryValue;
            }

            return total;
        }
    }
}
