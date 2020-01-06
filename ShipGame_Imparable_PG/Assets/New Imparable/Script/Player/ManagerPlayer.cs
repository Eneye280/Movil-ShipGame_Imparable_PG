using UnityEngine;

namespace Unstoppable.Player
{
    [RequireComponent(typeof(MovementPlayer), typeof(HealthPlayer))]
    [RequireComponent(typeof(BoxCollider), typeof(Rigidbody))]
    public class ManagerPlayer : MonoBehaviour
    {
        private HealthPlayer healthPlayer;
        private MovementPlayer movementPlayer;

        private void Awake()
        {
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

