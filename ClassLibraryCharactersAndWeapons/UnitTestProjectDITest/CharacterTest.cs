using System;
using ClassLibraryCharactersAndWeapons.Models;
using ClassLibraryCharactersAndWeapons.NinjectModules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace UnitTestProjectDITest
{
    [TestClass]
    public class CharacterTest
    {
        IKernel k;

        public CharacterTest()
        {
            k = new StandardKernel(new CharacterModule());
        }

        [TestMethod]
        public void SamuraiInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = k.Get<Samurai>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Samurai));
            Assert.IsInstanceOfType(c.Weapon, typeof(Katana));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = k.Get<Ninja>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Ninja));
            Assert.IsInstanceOfType(c.Weapon, typeof(Sword));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SharpshooterInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = k.Get<Sharpshooter>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Sharpshooter));
            Assert.IsInstanceOfType(c.Weapon, typeof(Gun));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SpaceMarineInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = k.Get<SpaceMarine>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(SpaceMarine));
            Assert.IsInstanceOfType(c.Weapon, typeof(BFG));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

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
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }
    }
}
