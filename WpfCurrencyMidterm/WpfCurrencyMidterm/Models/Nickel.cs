﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    [Serializable]
    public class Nickel : USCoin
    {
        public Nickel()
        {
            MonetaryValue = 0.05;
            Name = "Nickel";
        }

        public Nickel(USCoinMintMark MintMark)
        {
            MonetaryValue = 0.05;
            Name = "Nickel";
            this.MintMark = MintMark;
        }
    }
}
