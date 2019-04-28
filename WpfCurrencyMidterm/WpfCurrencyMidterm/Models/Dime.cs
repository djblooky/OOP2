using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    public class Dime : USCoin 
    {
        public Dime()
        {
            MonetaryValue = 0.10;
            Name = "US Dime";
        }
        public Dime(USCoinMintMark MintMark)
        {
            MonetaryValue = 0.10;
            Name = "US Dime";
            this.MintMark = MintMark;
        }
    }
}
