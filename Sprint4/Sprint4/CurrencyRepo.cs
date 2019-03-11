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
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            Coins.Add(c);
        }

        public ICurrencyRepo CreateChange(double Amount)
        {
            throw new NotImplementedException();
        }

        public ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }

        public CurrencyRepo()
        {
            Coins = new List<ICoin>();
        }

        public int GetCoinCount()
        {
            return Coins.Count;
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            throw new NotImplementedException();
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }

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
