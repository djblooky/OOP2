using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    [Serializable]
    public class Penny : USCoin
    {
        public Penny()
        {
            MonetaryValue = 0.01;
            Name = "US Penny";
        }

        public Penny(USCoinMintMark MintMark)
        {
            MonetaryValue = 0.01;
            Name = "US Penny";
            this.MintMark = MintMark;
        }
    }
}
