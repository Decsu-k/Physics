using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    public float speed = 2f;
    public float normalSpeed;
    public KeyCode moveRight;
    public KeyCode moveLeft;

    void Update()
    {
        if (Input.GetKey(moveRight))
        {
            float m_y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.RightArrow))
                transform.Rotate(Vector3.forward, m_y, Space.Self);
        }
        else if (Input.GetKey(moveLeft))
        {
            float m_y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.forward, m_y, Space.Self);
        }
    }   
    public void OnRight()
    {
        float m_y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.forward, m_y, Space.Self);
    }
    
    public void OnLeft()
    {
        if (Input.GetKey(moveLeft))
        {
            float m_y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(Vector3.forward, m_y, Space.Self);
        }
    }

    public void Stop()
    {
        transform.Rotate(Vector3.forward, Space.Self);
    }

}

