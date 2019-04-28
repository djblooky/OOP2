using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    public interface ICurrency
    {
        double MonetaryValue { get; }
        string Name { get; }
        string About();
    }
}
