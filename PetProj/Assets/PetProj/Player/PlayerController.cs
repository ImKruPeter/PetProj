using UnityEngine;
using Zenject;

namespace PetProj.Player
{
    public class PlayerController : IFixedTickable
    {
        public PlayerView PlayerView => _playerView;
        
        private PlayerView _playerView;
        private PlayerInputState _playerInputState;
        private PlayerModel _playerModel;

        public PlayerController(PlayerView playerView, PlayerInputState playerInputState, PlayerModel playerModel)
        {
            _playerView = playerView;
            _playerInputState = playerInputState;
            _playerModel = playerModel;
        }
        
        public void FixedTick()
        {
            if (_playerInputState.IsMovingLeft)
            {
                _playerView.PlayerRigidbody.AddForce(
                    Vector3.left * _playerModel.PlayerMoveSpeed);
            }

            if (_playerInputState.IsMovingRight)
            {
                _playerView.PlayerRigidbody.AddForce(
                    Vector3.right * _playerModel.PlayerMoveSpeed);
            }

            if (_playerInputState.IsMovingForward)
            {
                _playerView.PlayerRigidbody.AddForce(
                    Vector3.forward * _playerModel.PlayerMoveSpeed);
            }

            if (_playerInputState.IsMovingBackward)
            {
                _playerView.PlayerRigidbody.AddForce(
                    Vector3.back * _playerModel.PlayerMoveSpeed);
            }
        }
    }
}