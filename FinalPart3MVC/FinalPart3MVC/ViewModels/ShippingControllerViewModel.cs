using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalPart3MVC.ViewModels
{
    public class ShippingControllerViewModel
    {
        public string Test { get; set; }
        public List<string> ShippingDDLNames { get; set; }
        public double ShippingCost { get; set; }
        public string ShippingMessage { get; set; }

        public ShippingControllerViewModel()
        {
            Test = "Yee haw from Shipping View Model!";
            ShippingDDLNames = new List<string> { "yee", "haw", "howdy"};
        }
    }
}