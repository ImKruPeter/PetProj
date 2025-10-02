using UnityEngine;

namespace PetProj.Level
{
    public class LevelView : MonoBehaviour
    {
        public Transform PlayerSpawnPoint => playerSpawnPoint;
        
        [SerializeField] private Transform playerSpawnPoint;
    }
}