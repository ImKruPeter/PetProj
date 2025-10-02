using PetProj.Camera;
using PetProj.Player;
using Zenject;

namespace PetProj
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            PlayerInstaller.Install(Container);
            CameraInstaller.Install(Container);
        }
    }
}