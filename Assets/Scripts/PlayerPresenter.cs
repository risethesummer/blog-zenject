public class PlayerPresenter
{
    private readonly PlayerData _data;
    private readonly PlayerView _view;
    //Constructor injection
    public PlayerPresenter(PlayerData data, PlayerView view)
    {
        _data = data;
        _view = view;
    }
    public int Heal(int health = 1)
    {
        _data.Health += health;
        _view.UpdatePlayerStats(_data);
        return _data.Health;
    }
}