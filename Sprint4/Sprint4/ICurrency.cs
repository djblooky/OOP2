using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public interface ICurrency
    {
        double MonetaryValue { get; }
        string Name { get; }
        string About();
    }
}
