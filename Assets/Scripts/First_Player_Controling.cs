using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class First_Player_Controling : MonoBehaviour
{
    [SerializeField] private float player1_Speed = 2.5f;  //allows us to be able to change speed in Unity
    private Rigidbody2D rb2D;
    //private Vector2 jumpHeight;

    // Use this for initialization
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.W))  //makes player jump
        {
            GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
        }

        transform.Translate(playerSpeed * 0f, Time.deltaTime, 0f);  //makes player run
        */

        /*
        if (Input.GetKey(KeyCode.W))
        {
            //transform.Translate(new Vector2(0, 5) * Time.deltaTime * player1_Speed);
            //Debug.Log(KeyCode.W);
            transform.Translate(Vector3.up);
        }

        if (Input.GetKey(KeyCode.S))
        {
            //transform.Translate(new Vector2(0, -5) * Time.deltaTime * player1_Speed);
            transform.Translate(Vector3.down);
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(new Vector2(-5, 0) * Time.deltaTime * player1_Speed);
            transform.Translate(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(new Vector2(5, 0) * Time.deltaTime * player1_Speed);
            transform.Translate(Vector3.right);
        }

        void OnCollisionEnter(Collision collision)
        {
            if (gameObject.CompareTag("Wall"))
                {
                rb2D.velocity = Vector3.zero;
            }
        } */
    }

    private void FixedUpdate()
    {
         if (Input.GetKey(KeyCode.A))
             rb2D.AddForce(Vector3.left * player1_Speed * 2);

         if (Input.GetKey(KeyCode.D))
             rb2D.AddForce(Vector3.right * player1_Speed * 2);

         if (Input.GetKey(KeyCode.W))
             rb2D.AddForce(Vector3.up * player1_Speed * 3);

         if (Input.GetKey(KeyCode.S))
             rb2D.AddForce(Vector3.down * player1_Speed * 5); 

        /*
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        rb2D.AddForce(move * player1_Speed); */
    }
}
