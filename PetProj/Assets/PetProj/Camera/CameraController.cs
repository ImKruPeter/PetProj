using PetProj.Player;
using UnityEngine;
using Zenject;

namespace PetProj.Camera
{
    public class CameraController : ITickable
    {
        private CameraView _cameraView;
        private PlayerController _playerController;
        
        private Vector3 _vector3Buffer = new Vector3(0,5,-10);
        
        public CameraController(CameraView cameraView, PlayerController playerController)
        {
            _cameraView = cameraView;
            _playerController = playerController;

            _vector3Buffer.x = _playerController.PlayerView.transform.position.x;

            _cameraView.transform.position = _vector3Buffer;
        }
        
        public void Tick()
        {
            _vector3Buffer.x = Mathf.Lerp(_cameraView.transform.position.x, _playerController.PlayerView.transform.position.x, 0.025f);
            
            _cameraView.transform.position = _vector3Buffer;
        }
    }
}