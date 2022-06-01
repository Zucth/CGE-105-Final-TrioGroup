using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balls_movement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private float speed = 10f;
    private float x;
    private float y;
    //public GameObject BallDissapear;
    private Text LeftScoreText;
    private Text RightScoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        y = Random.Range(-5, 6);
        x = Random.Range(-2, 3);

        rb2D.AddForce(new Vector2(x, y) * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hit Detect");
        GameObject ball = Instantiate(BallDissapear) as GameObject;
        ball.transform.position = transform.position;
        Destroy(other.gameObject);

        this.gameObject.SetActive(false);
    } */

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if (collision.gameObject.tag == "left_goal")
        {
            //LeftScoreText.P1_Text("Hello");
        }
        if (collision.gameObject.tag == "right_goal")
        {
            GameRestart();
        }
    }
    public void GameRestart()
    {
        
    }

}
