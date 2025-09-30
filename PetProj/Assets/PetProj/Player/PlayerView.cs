using UnityEngine;

namespace PetProj.Player
{
    public class PlayerView : MonoBehaviour
    {
        public Rigidbody PlayerRigidbody => _playerRigidbody;
        public CapsuleCollider PlayerCollider => _playerCollider;
        public MeshRenderer PlayerMeshRenderer => _playerMeshRenderer;
    
        [SerializeField] private Rigidbody _playerRigidbody;
        [SerializeField] private CapsuleCollider _playerCollider;
        [SerializeField] private MeshRenderer _playerMeshRenderer;
        void Start()
        {
        
        }

        void Update()
        {
        
        }
    }
}
