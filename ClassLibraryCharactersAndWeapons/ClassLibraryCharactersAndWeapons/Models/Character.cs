using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCharactersAndWeapons.Models
{
    public abstract class Character
    {
        protected IWeapon weapon;

        public IWeapon Weapon
        {
            get { return weapon; }
            protected set { weapon = value; }
        }

        public Character(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public string Attack(string target)
        {
            return weapon.Hit(target);
        }
    }
}