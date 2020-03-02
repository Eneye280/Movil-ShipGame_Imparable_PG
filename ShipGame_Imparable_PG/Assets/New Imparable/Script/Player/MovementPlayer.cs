using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}
namespace Unstoppable.Player
{
    public class MovementPlayer : MonoBehaviour
    {
        [Range(0,100)] 
        [SerializeField] internal float speedPlayer;
        [SerializeField] internal float tiltPlayer;

        [SerializeField] internal Boundary boundary;

        public void Movement()
        {
            if(ManagerPlayer.instance.attributesPlayer == ManagerPlayer.AttributesPlayer.fly)
            {
                float moveHorizontal = CrossPlatformInputManager.GetAxis("Horizontal");
                float moveVertical = CrossPlatformInputManager.GetAxis("Vertical");

                Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
                ManagerPlayer.instance.rb_Player.velocity = movement * speedPlayer;

                ManagerPlayer.instance.rb_Player.position = new Vector3
                (
                    Mathf.Clamp(ManagerPlayer.instance.rb_Player.position.x, boundary.xMin, boundary.xMax),
                    0.0f,
                    Mathf.Clamp(ManagerPlayer.instance.rb_Player.position.z, boundary.zMin, boundary.zMax)
                );

                ManagerPlayer.instance.rb_Player.rotation =
                    Quaternion.Euler(0.0f, 0.0f, ManagerPlayer.instance.rb_Player.velocity.x * -tiltPlayer);
            }
        }
    }
}
