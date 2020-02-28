using UnityEngine;

namespace Unstoppable
{
    [RequireComponent(typeof(Rigidbody))]
    public class BulletBasic : MonoBehaviour
    {
        private static BulletBasic bullet;
        public static BulletBasic instance
        {
            get
            {
                if(!bullet)
                {
                    bullet = FindObjectOfType<BulletBasic>();
                    if(!bullet)
                    {
                        var singleton = new GameObject(typeof(BulletBasic).ToString());
                        bullet = singleton.AddComponent<BulletBasic>();
                    }
                }
                return bullet;
            }
        }

        private Rigidbody rb_Bullet;

        [Space(10)][Range(0,100)]
        public float howMuchHealth;
        [Range(0,100)]
        public float speed;

        [Space(10)][Range(0, 10)]
        public float timeRespawn;

        private void Awake()
        {
            rb_Bullet = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            rb_Bullet.velocity = transform.forward * speed;
        }
        private void OnEnable()
        {
            Invoke("OnDisable",timeRespawn);
        }
        private void OnDisable()
        {
            this.transform.gameObject.SetActive(false);
        }
    }
}

