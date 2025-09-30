namespace PetProj.Player
{
    public class PlayerController
    {
        private PlayerView _playerView;
        private PlayerInputState _playerInputState;

        public PlayerController(PlayerView playerView, PlayerInputState playerInputState)
        {
            _playerView = playerView;
            _playerInputState = playerInputState;
        }
    }
}