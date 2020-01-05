using UnityEngine;

namespace Unstoppable
{
    public class Parallax : MonoBehaviour
    {
        [Header("City and Cloud")]
        public Transform[] BloqueCiudad;
        public Material materialNube;
        [SerializeField] private float velocidadCiuadad;
        [SerializeField] private float velocidadNube;

        public void CityAndCloud()
        {
            if (GameManager.instance.utility == GameManager.utilitiesShip.fly)
            {
                for (int i = 0; i < BloqueCiudad.Length; i++)
                {
                    BloqueCiudad[i].Translate(-Vector3.forward * velocidadCiuadad * Time.deltaTime);

                    if (BloqueCiudad[i].position.z < -67.815f)
                    {
                        Vector3 newPosicion = BloqueCiudad[i].position;
                        newPosicion.z = 40f;
                        BloqueCiudad[i].position = newPosicion;
                    }
                }

                Vector2 newOffset = materialNube.mainTextureOffset;
                newOffset.y -= velocidadNube * Time.deltaTime;
                materialNube.mainTextureOffset = newOffset;

            }
        }

    }
}
