using UnityEngine;

namespace Unstoppable
{
    public class ControllerCamera : MonoBehaviour
    {
        public Transform player;
        private void Update()
        {
            transform.position = new Vector3(player.position.x / 6, transform.position.y, transform.position.z);
        }
    }
}

