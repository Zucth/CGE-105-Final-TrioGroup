using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balls_movement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float max_speed = 2f;
    private float x;
    private float y;
    //public GameObject BallDissapear;



    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

        //y = Random.Range(-5, 6);
        x = Random.Range(-4, 2);

        rb2D.AddForce(new Vector2(x, 0) * speed);

        //gameObject.active = false;
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "left_goal")
        {
            //Debug.Log("hi");
        }
        if (collision.gameObject.tag == "right_goal")
        {

        }
    }

    private void FixedUpdate()
    {
        if(rb2D.velocity.magnitude > max_speed)
        {
            rb2D.velocity = Vector2.ClampMagnitude(rb2D.velocity, max_speed);
        }
    }
}
