using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Settle : MonoBehaviour
{
    [SerializeField]
    private Text LeftScoreText;
    [SerializeField]
    private Text RightScoreText;


    private int P1Score = 0;
    private int P2Score = 0;


    public void UpdatePlayer1_Score()
    {
        P1Score++;
        LeftScoreText.text = P1Score.ToString();
    }

    public void UpdatePlayer2_Score()
    {
        P2Score++;
        RightScoreText.text = P2Score.ToString();
       
    }

    public void ResetScore()
    {
        P1Score = 0;
        P2Score = 0;
        LeftScoreText.text = P1Score.ToString();
        RightScoreText.text = P2Score.ToString();
    }
}
