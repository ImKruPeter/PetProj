using UnityEngine;
using Zenject;

namespace PetProj.Player
{
    public class PlayerInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerView>().FromComponentInNewPrefab(Resources.Load("Player")).AsSingle().NonLazy();
            Container.Bind<PlayerInputHandler>().AsSingle().NonLazy();
            Container.Bind<PlayerController>().AsSingle().NonLazy();
        }
    }
}