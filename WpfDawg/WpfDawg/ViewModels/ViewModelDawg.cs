using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDawg.Models;

namespace WpfDawg.ViewModels
{
    class ViewModelDawg
    {
        Dawg Dawg;

        public string Name
        {
            get { return Dawg.Name; }
            set { Dawg.Name = value; }
        }

        public double Cost
        {
            get { return Dawg.Cost; }
            set { Dawg.Cost = value; }
        }

        public bool IsVegan
        {
            get { return Dawg.IsVegan; }
            set { Dawg.IsVegan = value; }
        }

        public ViewModelDawg(Dawg Dawg)
        {
            this.Dawg = Dawg;
        }


    }
}
