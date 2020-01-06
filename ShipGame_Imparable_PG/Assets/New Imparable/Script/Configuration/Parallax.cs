using UnityEngine;

namespace Unstoppable
{
    public class Parallax : MonoBehaviour
    {
        [Header("City and Cloud")]
        public Transform[] BloqueCiudad;
        public Material materialCloud;
        [SerializeField] private float velocityCity;
        [SerializeField] private float velocityCloud;

        public void CityAndCloud()
        {
            if (GameManager.instance.utility == GameManager.utilitiesShip.fly)
            {
                for (int i = 0; i < BloqueCiudad.Length; i++)
                {
                    BloqueCiudad[i].Translate(-Vector3.forward * velocityCity * Time.deltaTime);

                    if (BloqueCiudad[i].position.z < -67.815f)
                    {
                        Vector3 newPosicion = BloqueCiudad[i].position;
                        newPosicion.z = 40f;
                        BloqueCiudad[i].position = newPosicion;
                    }
                }

                Vector2 newOffset = materialCloud.mainTextureOffset;
                newOffset.y -= velocityCloud * Time.deltaTime;
                materialCloud.mainTextureOffset = newOffset;

            }
        }

    }
}
