using UnityEngine;
using Zenject;

public class InputHandler : ITickable
{
    private readonly PlayerPresenter _playerPresenter;
    public InputHandler(PlayerPresenter playerPresenter)
    {
        _playerPresenter = playerPresenter;
    }
    public void Tick()
    {
        if (Input.GetKeyDown(KeyCode.E))
            _playerPresenter.Heal();
    }
}