using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    public interface IBankNote: ICurrency
    {
        int Year { get; }
    }
}
