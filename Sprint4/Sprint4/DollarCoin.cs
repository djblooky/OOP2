﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public class DollarCoin : USCoin
    {
        public DollarCoin()
        {
            MonetaryValue = 1.00;
            Name = "US Dollar Coin";
        }

        public DollarCoin(USCoinMintMark MintMark)
        {
            MonetaryValue = 1.00;
            Name = "US Dollar Coin";
            this.MintMark = MintMark;
        }
    }
}
