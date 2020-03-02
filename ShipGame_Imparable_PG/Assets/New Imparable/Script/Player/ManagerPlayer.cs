using UnityEngine;

namespace Unstoppable.Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(MovementPlayer), typeof(HealthPlayer))]
    public class ManagerPlayer : MonoBehaviour
    {
        private static ManagerPlayer managerPlayer;
        public static ManagerPlayer instance
        {
            get
            {
                if(!managerPlayer)
                {
                    managerPlayer = FindObjectOfType<ManagerPlayer>();

                    if(!managerPlayer)
                    {
                        var singleton = new GameObject(typeof(ManagerPlayer).ToString());
                        managerPlayer = singleton.AddComponent<ManagerPlayer>();
                    }
                }
                return managerPlayer;
            }
        }

        internal Rigidbody rb_Player;
        public enum AttributesPlayer
        {
            fly, death
        }
        public AttributesPlayer attributesPlayer;

        [SerializeField] private HealthPlayer healthPlayer;
        [SerializeField] private MovementPlayer movementPlayer;

        private void Awake()
        {
            rb_Player = GetComponent<Rigidbody>();

            healthPlayer = GetComponent<HealthPlayer>();
            movementPlayer = GetComponent<MovementPlayer>();
        }
        private void Update()
        {
            healthPlayer.Death();
            movementPlayer.Movement();
            
        }
     }
}

