using PetProj.Camera;
using PetProj.Level;
using PetProj.Player;
using Zenject;

namespace PetProj
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            LevelInstaller.Install(Container);
            PlayerInstaller.Install(Container);
            CameraInstaller.Install(Container);
        }
    }
}