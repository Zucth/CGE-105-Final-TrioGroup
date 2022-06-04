using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WallGoal : MonoBehaviour
{
    //[System.Serializable]
    //public class ScoreManager : scoreTrigger{ };
    
    [SerializeField]
    private UnityEvent scoreTrigger;

    [SerializeField]
    private Text CenterText;

    public float timeStart = 5;

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

    /*
    [SerializeField]
    private GameObject player1_board;
    [SerializeField]
    private GameObject player2_board;
    [SerializeField]
    private GameObject ball_board; */


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the ball hits goal ++invoke ScoreboardTrigger
        //destroy ball and paddle object (remove this feauture)
        //do GameReset func.

        if (collision.gameObject.tag == "ball")
        {
            scoreTrigger.Invoke();

            //Destroy(player1_board, 1f);
            //Destroy(player2_board, 1f);
            //Destroy(ball_board, 1f);

            GameReset();
        }
    }

    private void GameReset()
    {
        //do the count down 5 4 3 2 1.. remove number.
        //create new paddle and ball at the position (change to set ball and paddle at the position)
        {
            CenterText.text = timeStart.ToString();
            while (timeStart > 0)
            {
                timeStart -= Time.deltaTime;
            }
            CenterText.text = "Ready?";
            yield return new WaitForSeconds(1f);
            CenterText.text = " ";

            //Instantiate(player1, spawnPoint1.position, spawnPoint1.rotation);
            //Instantiate(player2, spawnPoint2.position, spawnPoint2.rotation);
            //Instantiate(ball1, spawnPoint3.position, spawnPoint3.rotation);

            /*
            player1.transform.position = spawnPoint1.transform.position;
            player2.transform.position = spawnPoint2.position;
            ball1.transform.position = spawnPoint3.position; */

            //player1.transform.position = new Vector3(-8, 0, 0);

            player1.transform.position = new Vector2(0, 0);


        }
    }


}
