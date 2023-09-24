using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private int playerHealth;
    [SerializeField] private PlayerView playerView;
    public override void InstallBindings()
    {
        InstallPlayer();
        InstallInputHandler();
    }
    private void InstallPlayer()
    {
        Container.Bind<PlayerData>().AsSingle().WithArguments(playerHealth);
        Container.BindInstance(playerView).AsSingle();
        Container.Bind<PlayerPresenter>().AsSingle();
    }
    private void InstallInputHandler()
    {
        Container.BindInterfacesAndSelfTo<InputHandler>().AsSingle().NonLazy(); //Nhớ thêm BindInterfacesAndSelfTo và NonLazy() nha
    }
}