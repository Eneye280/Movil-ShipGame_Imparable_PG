using UnityEngine;
using Unstoppable;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManager;
    public static GameManager instance
    {
        get
        {
            if (!gameManager)
            {
                gameManager = FindObjectOfType<GameManager>();
                if (!gameManager)
                {
                    var singleton = new GameObject(typeof(GameManager).ToString());
                    gameManager = singleton.AddComponent<GameManager>();
                }
            }
            return gameManager;
        }
    }

    [Header("Add Script")]
    public Parallax parallax;

    [Space(10)]
    public utilitiesShip utility;
    public enum utilitiesShip
    {
        fly, death
    }

    private void Update()
    {
        parallax.CityAndCloud();
    }
}

