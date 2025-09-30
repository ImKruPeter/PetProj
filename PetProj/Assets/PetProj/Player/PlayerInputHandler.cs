using UnityEngine;
using Zenject;

namespace PetProj.Player
{
    public class PlayerInputHandler : ITickable
    {
        readonly PlayerInputState _inputState;

        public PlayerInputHandler(PlayerInputState inputState)
        {
            _inputState = inputState;
        }

        public void Tick()
        {
            _inputState.IsMovingLeft = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
            _inputState.IsMovingRight = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);
            _inputState.IsMovingForward = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
            _inputState.IsMovingBackward = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        }
    }
}