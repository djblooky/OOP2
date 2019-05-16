using ClassLibraryCharactersAndWeapons.Models;
using Unity;
using Unity.Injection;

namespace ClassLibraryCharactersAndWeapons.UnityContainers
{
    public static class UnityBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IWeapon, Sword>();
            container.RegisterType<Samurai>(new InjectionConstructor(new Katana()));
            container.RegisterType<Ninja>(new InjectionConstructor(new Sword()));
            container.RegisterType<SpaceMarine>(new InjectionConstructor(new BFG()));
            container.RegisterType<Sharpshooter>(new InjectionConstructor(new Gun()));
        }
    }
}
