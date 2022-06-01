using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        walk();
    }
    
    void walk()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        //rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        rb.AddForce(moveVector * speed);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            SceneManager.LoadScene(0);
        }
    }
}
