using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryCharactersAndWeapons.Models
{
    public class Ninja : Character
    {
        public Ninja(IWeapon weapon) : base(weapon)
        {

        }
    }
}