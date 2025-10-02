using UnityEngine;
using Zenject;

namespace PetProj.Player
{
    public class PlayerInstaller : Installer<PlayerInstaller>
    {
        public override void InstallBindings()
        {
            Container.Bind<PlayerModel>().FromScriptableObjectResource("PlayerModel").AsSingle().NonLazy();
            Container.Bind<PlayerView>().FromComponentInNewPrefab(Resources.Load("Player")).AsSingle().NonLazy();
            Container.Bind<PlayerInputState>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<PlayerInputHandler>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<PlayerController>().AsSingle().NonLazy();
        }
    }
}