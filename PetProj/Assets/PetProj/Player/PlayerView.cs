using UnityEngine;

namespace PetProj.Player
{
    public class PlayerView : MonoBehaviour
    {
        public Rigidbody PlayerRigidbody => playerRigidbody;
        public CapsuleCollider PlayerCollider => playerCollider;
        public MeshRenderer PlayerMeshRenderer => playerMeshRenderer;
    
        [SerializeField] private Rigidbody playerRigidbody;
        [SerializeField] private CapsuleCollider playerCollider;
        [SerializeField] private MeshRenderer playerMeshRenderer;
    }
}
