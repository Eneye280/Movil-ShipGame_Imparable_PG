using UnityEngine;

namespace Unstoppable
{
    public abstract class ManagerHealth : MonoBehaviour
    {
        public float healthBasic;

        public abstract void TakeDamage();
        public abstract void Death();

    }
}

