using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Second_Player_Controlling : MonoBehaviour
{
    [SerializeField] private float player2_Speed = 2.5f;  //allows us to be able to change speed in Unity
    private Rigidbody2D rb2D;

    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.J))
            rb2D.AddForce(Vector3.left * player2_Speed * 2);

        if (Input.GetKey(KeyCode.L))
            rb2D.AddForce(Vector3.right * player2_Speed * 2);

        if (Input.GetKey(KeyCode.I))
            rb2D.AddForce(Vector3.up * player2_Speed * 3);

        if (Input.GetKey(KeyCode.K))
            rb2D.AddForce(Vector3.down * player2_Speed * 5);
    }
}
