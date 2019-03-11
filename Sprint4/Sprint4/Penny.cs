using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public class Penny : USCoin
    {
        public Penny()
        {
            MonetaryValue = .01;
            Name = "US Penny";
        }

        public Penny(USCoinMintMark MintMark)
        {
            MonetaryValue = .01;
            Name = "US Penny";
            this.MintMark = MintMark;
        }
    }
}
