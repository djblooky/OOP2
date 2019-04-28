using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    public class Quarter : USCoin 
    {
        public Quarter()
        {
            MonetaryValue = 0.25;
            Name = "US Quarter";
        }
        public Quarter(USCoinMintMark MintMark)
        {
            MonetaryValue = 0.25;
            Name = "US Quarter";
            this.MintMark = MintMark;
        }
    }
}
