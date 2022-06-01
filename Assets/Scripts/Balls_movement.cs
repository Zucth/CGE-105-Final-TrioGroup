using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls_movement : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField] private float speed = 10f;
    private float x;
    private float y;

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
}
