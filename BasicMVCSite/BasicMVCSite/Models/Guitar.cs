using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class Guitar : StringInstrument
    {
        public Guitar()
        {
            Sound = "Strum";
            NumberOfStrings = 6;
            SoundCount = 0;
            Cost = 199.99;
            IsPlaying = false;
        }
    }
}
