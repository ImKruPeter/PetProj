using Zenject;

namespace PetProj.Level
{
    public class LevelInstaller : Installer<LevelInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<LevelView>().FromComponentInNewPrefabResource("LevelTest").AsSingle().NonLazy();
            Container.Bind<LevelManager>().AsSingle().NonLazy();
        }
    }
}