using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unstoppable
{
    public class ControllerCamera : MonoBehaviour
    {
        public Transform player;
        private void Update()
        {
            transform.position = new Vector3(player.position.x / 4, transform.position.y, transform.position.z);
        }
    }
}

