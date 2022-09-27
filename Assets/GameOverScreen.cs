using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public static bool isGameOver;
    public GameObject gameOverScreen;

    private void Awake()
    {
        isGameOver = false;
    }


    void Update()
    {
        if (isGameOver) 
        {
            gameOverScreen.SetActive(true);
        }

    }


}
