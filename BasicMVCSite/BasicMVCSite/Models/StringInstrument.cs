using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2
{
    public class StringInstrument : Instrument
    {
        public int NumberOfStrings { get; protected set; }

        public StringInstrument()
        {
            Material = "Wood";
        }

        public override string About()
        {
            base.About();
            return this + $" has {NumberOfStrings} strings";
        }
    }
}
