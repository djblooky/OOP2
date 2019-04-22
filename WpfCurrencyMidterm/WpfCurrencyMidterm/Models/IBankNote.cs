using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint4
{
    public interface IBankNote: ICurrency
    {
        int Year { get; }
    }
}
