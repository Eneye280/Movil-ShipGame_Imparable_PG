using UnityEngine;
using TMPro;

namespace Unstoppable.Player
{
    public class HealthPlayer : ManagerHealth
    {
        public TextMeshProUGUI textHealth;

        public override void Death()
        {
            if (healthBasic <= 0)
            {
                Destroy(gameObject);
            }
        }
        public override void TakeDamage()
        {
            textHealth.text = healthBasic.ToString() + " %";
            healthBasic -= BulletBasic.instance.howMuchHealth;
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("bulletEnemy"))
            {
                TakeDamage();
            }

        }
    }
}

