using UnityEngine;

namespace PetProj.Player
{
    [CreateAssetMenu(menuName = "Models/PlayerModel", fileName = "PlayerModel")]
    public class PlayerModel : ScriptableObject
    {
        public float PlayerMoveSpeed => playerMoveSpeed;
        
        [SerializeField] private float playerMoveSpeed;
    }
}