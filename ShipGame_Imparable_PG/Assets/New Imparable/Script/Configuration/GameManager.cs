using UnityEngine;
using Unstoppable.Player;

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
    
    public Parallax parallax;

    private void Update()
    {
        parallax.CityAndCloud();
    }
}

