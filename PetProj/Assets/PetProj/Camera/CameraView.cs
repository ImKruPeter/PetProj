using UnityEngine;

namespace PetProj.Camera
{
    public class CameraView : MonoBehaviour
    {
        public UnityEngine.Camera CameraComponent => cameraComponent;
        
        [SerializeField] private UnityEngine.Camera cameraComponent;
    }
}