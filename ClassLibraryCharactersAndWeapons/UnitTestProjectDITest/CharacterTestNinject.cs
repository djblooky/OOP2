using ClassLibraryCharactersAndWeapons;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace UnitTestProjectDITest
{
    [TestClass]
    class CharacterTestNinject
    {
        IKernel k;

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
    }
}
