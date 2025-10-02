using Zenject;

namespace PetProj.Camera
{
    public class CameraInstaller : Installer<CameraInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<CameraView>().FromComponentInNewPrefabResource("Main Camera").AsSingle().NonLazy();
            Container.BindInterfacesTo<CameraController>().AsSingle().NonLazy();
        }
    }
}