using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            throw new NotImplementedException();
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

        }

        public int GetCoinCount()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public double TotalValue()
        {
            throw new NotImplementedException();
        }
    }
}
