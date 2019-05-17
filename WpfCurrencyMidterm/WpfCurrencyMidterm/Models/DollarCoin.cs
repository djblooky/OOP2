using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    [Serializable]
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
