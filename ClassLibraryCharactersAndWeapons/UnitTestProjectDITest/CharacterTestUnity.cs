using System;
using ClassLibraryCharactersAndWeapons.Models;
using ClassLibraryCharactersAndWeapons.UnityContainers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;
using Unity.Injection;

namespace UnitTestProjectDITest
{
    [TestClass]
    public class CharacterTestUnity
    {
        IUnityContainer unityContainer;

        public CharacterTestUnity()
        {
            unityContainer = new UnityContainer();
            UnityBootstrap.RegisterTypes(unityContainer);
        }

        [TestMethod]
        public void SamuraiUnityInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = unityContainer.Resolve<Samurai>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Samurai));
            Assert.IsInstanceOfType(c.Weapon, typeof(Katana));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void NinjaUnityInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = unityContainer.Resolve<Ninja>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Ninja));
            Assert.IsInstanceOfType(c.Weapon, typeof(Sword));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SpaceMarineUnityInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = unityContainer.Resolve<SpaceMarine>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(SpaceMarine));
            Assert.IsInstanceOfType(c.Weapon, typeof(BFG));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

        [TestMethod]
        public void SharpshooterUnityInject()
        {
            //arrange
            Character c;
            string attackTarget = "bad guy";

            //act
            c = unityContainer.Resolve<Sharpshooter>();

            //assert
            Assert.IsInstanceOfType(c, typeof(Character));
            Assert.IsInstanceOfType(c, typeof(Sharpshooter));
            Assert.IsInstanceOfType(c.Weapon, typeof(Gun));
            Assert.AreEqual(c.Attack(attackTarget), $"{c.Weapon.Name} hits {attackTarget}");
        }

    }
}
