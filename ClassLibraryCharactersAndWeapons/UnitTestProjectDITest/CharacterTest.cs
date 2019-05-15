using System;
using ClassLibraryCharactersAndWeapons;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectDITest
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void SamuraiNoInject()
        {
            //arrange
            Weapon w;
            Character c;
            string attackTarget = "bad guy";

            //act
            w = new Katana();
            c = new Samurai(w);

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Samurai));
            Assert.IsInstanceOfType(c.Weapon, typeof(Katana));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}")
        }
    }
}
