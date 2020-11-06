using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
namespace Unstoppable.Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class MovementPlayer : MonoBehaviour
    {
        [Range(0,100)]public float speedPlayer;
        public float tiltPlayer;

        public Boundary boundary;
        private Rigidbody rb_Player;

        private void Awake()
        {
            rb_Player = GetComponent<Rigidbody>();
        }

        public void Movement()
        {

            float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
            float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
            rb_Player.velocity = movement * speedPlayer;

            rb_Player.position = new Vector3
            (
                Mathf.Clamp(rb_Player.position.x, boundary.xMin, boundary.xMax),
                0.0f,
                Mathf.Clamp(rb_Player.position.z, boundary.zMin, boundary.zMax)
            );

            rb_Player.rotation = Quaternion.Euler(0.0f, 0.0f, rb_Player.velocity.x * -tiltPlayer);
        }
    }
}
