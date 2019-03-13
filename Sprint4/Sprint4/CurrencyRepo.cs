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
            CurrencyRepo repo = new CurrencyRepo();

            if (repo.Coins.Count > 0) //if coins isn't empty
            {
                repo.Coins.Clear(); //empty coins
            }
            
            while(0 < Math.Round(Amount,2)) //while enough change hasn't been made
            {
                if(Math.Round(Amount,2) >= 1.0)
                {
                    repo.AddCoin(new DollarCoin());
                    Amount -= 1.0;
                }
                else if(Math.Round(Amount,2) >= 0.5)
                {
                    repo.AddCoin(new HalfDollarCoin());
                    Amount -= 0.5;
                }
                else if(Math.Round(Amount,2) >= 0.25)
                {
                    repo.AddCoin(new Quarter());
                    Amount -= 0.25;
                }
                else if(Math.Round(Amount,2) >= 0.10)
                {
                    repo.AddCoin(new Dime());
                    Amount -= 0.10;
                }
                else if(Math.Round(Amount,2) >= 0.05)
                {
                    repo.AddCoin(new Nickel());
                    Amount -= 0.05;
                }
                else if(Math.Round(Amount,2) >= 0.01)
                {
                    repo.AddCoin(new Penny());
                    Amount -= 0.01;
                }
            }

            return repo;
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
