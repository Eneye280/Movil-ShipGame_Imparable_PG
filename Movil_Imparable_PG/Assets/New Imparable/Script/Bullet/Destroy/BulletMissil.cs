using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unstoppable
{
    public class BulletMissil : MonoBehaviour
    {
        private Rigidbody rb_Bullet;

        [Space(10)]
        [Range(0, 100)]
        public float howMuchHealth;
        [Range(0, 100)]
        public float speed;

        private void Awake()
        {
            rb_Bullet = GetComponent<Rigidbody>();
        }
        private void Update()
        {
            rb_Bullet.velocity = Vector3.forward * speed;
            StartCoroutine(DestroyMissil());
        }

        IEnumerator DestroyMissil()
        {
            yield return new WaitForSeconds(2.5f);
            Destroy(gameObject);
        }
    }

}
