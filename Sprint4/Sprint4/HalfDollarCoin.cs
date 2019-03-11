using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public class HalfDollarCoin : USCoin
    {
        public DollarCoin()
        {
            MonetaryValue = 0.5;
            Name = "US Half Dollar Coin";
        }

        public DollarCoin(USCoinMintMark MintMark)
        {
            MonetaryValue = 1.00;
            Name = "US Half Dollar Coin";
            this.MintMark = MintMark;
        }
    }
}
