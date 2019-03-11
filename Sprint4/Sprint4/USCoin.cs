using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public abstract class USCoin : Coin
    {
        USCoinMintMark MintMark;

        public override string About()
        {
            return "";
        }

        public string GetMintNameFromMark()
        {
            return "";
        }

        public USCoin()
        {

        }

        public USCoin() //overload
        {

        }
    }
}
