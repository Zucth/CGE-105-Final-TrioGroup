using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_setting : MonoBehaviour
{
    public static bool gameIsPaused;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }

        //check if game restart or not
        if (Input.GetKey(KeyCode.Space))
        {
            GameRestart();
        }
    }
    public void GameRestart()
    {
        Debug.Log(KeyCode.Space);
    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
