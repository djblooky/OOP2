using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCharactersAndWeapons.Models
{
    public abstract class Weapon : IWeapon
    {
        protected string name;

        public string Name
        {
            get { return name; }
        }

        public string Hit(string target)
        {
            return $"{name} hits {target}";
        }

        public Weapon()
        {
            name = "not a weapon!";
        }
    }
}