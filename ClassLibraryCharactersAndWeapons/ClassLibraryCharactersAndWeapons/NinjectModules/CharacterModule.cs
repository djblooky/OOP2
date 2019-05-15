using Ninject.Modules;

namespace ClassLibraryCharactersAndWeapons.NinjectModules
{
    public class CharacterModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Sword>(); //any character that needs an Iweapon will get a sword
            Bind<IWeapon>().To<Katana>().WhenInjectedExactlyInto<Samurai>();

        }
    }
}
