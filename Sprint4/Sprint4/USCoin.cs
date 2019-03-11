﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public abstract class USCoin : Coin
    {
        public USCoinMintMark MintMark;

        public override string About()
        { 
            return base.About() + " It was made in " + GetMintNameFromMark();
        }

        public string GetMintNameFromMark(USCoinMintMark m)
        {
            string mint = m;

            switch (MintMark)
            {
                case USCoinMintMark.D: mint = "Denver";
                    break;
                case USCoinMintMark.P: mint = "Pennsylvania";
                    break;
                default: mint = "Denver";
                    break;
            }

            return mint;
        }

        public string GetMintNameFromMark()
        {
            return GetMintNameFromMark(MintMark);
        }

        public USCoin()
        {
            MintMark = USCoinMintMark.D;
            Year = System.DateTime.Now.Year; //current year
        }

        public USCoin(USCoinMintMark MintMark) //overload
        {
            this.MintMark = MintMark;
        }
    }
}
