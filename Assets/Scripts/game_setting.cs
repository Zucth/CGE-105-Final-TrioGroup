using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class game_setting : MonoBehaviour
{
    public static bool gameIsPaused;

    [SerializeField]
    private Text CenterText;

    [SerializeField]
    private UnityEvent RestartAndResetScore;

    //player 1
    public GameObject player1;
    [SerializeField]
    private Transform spawnPoint1;

    //player 2
    public GameObject player2;
    [SerializeField]
    private Transform spawnPoint2;

    //balls
    public GameObject ball1;
    [SerializeField]
    private Transform spawnPoint3; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }

        //check if game restart or not
        if (Input.GetKey(KeyCode.Escape))
        {
            GameRestart();
        }
    }
    public void GameRestart()
    {
        RestartAndResetScore.Invoke();

        player1.transform.position = spawnPoint1.position;
        player2.transform.position = spawnPoint2.position;
        ball1.transform.position = spawnPoint3.position;

    }

    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            CenterText.text = "PAUSE!";

        }
        else
        {
            Time.timeScale = 1;
            CenterText.text = " ";
        }
    }
}
