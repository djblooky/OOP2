using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    public class HalfDollarCoin : USCoin
    {
        public HalfDollarCoin()
        {
            MonetaryValue = 0.5;
            Name = "US Half Dollar Coin";
        }

        public HalfDollarCoin(USCoinMintMark MintMark)
        {
            MonetaryValue = 0.5;
            Name = "US Half Dollar Coin";
            this.MintMark = MintMark;
        }
    }
}
