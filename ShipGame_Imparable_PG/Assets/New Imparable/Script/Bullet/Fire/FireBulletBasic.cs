using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unstoppable
{
    public class FireBulletBasic : MonoBehaviour
    {

        [Header("Bullet Basic")]
        public GameObject bulletBasic;
        public Transform positionBulletBasic;
        public int countBulletBasic;

        [Space(10)]
        public List<GameObject> bulletBasicList;

        private void Start()
        {
            positionBulletBasic = this.transform;

            for (int i = 0; i < countBulletBasic; i++)
            {
                GameObject bullet = Instantiate(bulletBasic);
                bulletBasicList.Add(bullet);
                bullet.transform.parent = this.transform;
                bullet.SetActive(false);
            }

            InvokeRepeating("FireBullet", .01f, .1f);

        }
        public void FireBullet()
        {
            for (int i = 0; i < bulletBasicList.Count; i++)
            {
                if(bulletBasicList[i].activeInHierarchy == false)
                {
                    bulletBasicList[i].SetActive(true);
                    bulletBasicList[i].transform.position = positionBulletBasic.position;
                    bulletBasicList[i].transform.rotation = positionBulletBasic.rotation;
                    break;
                }
            }
        }
    }
}

