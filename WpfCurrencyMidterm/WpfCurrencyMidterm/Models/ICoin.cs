using System;
using System.Collections.Generic;
using System.Text;

namespace WpfCurrencyMidterm.Models
{
    public interface ICoin :ICurrency
    {
        int Year { get; }
    }
}
