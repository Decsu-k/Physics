using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GroundMove : MonoBehaviour
{
    public float speed = 2f;
    public float normalSpeed;
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public Transform ground;

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
            transform.Rotate(new Vector3(), m_y, Space.Self);
    }

    public void OnLeft()
    {
        if (Input.GetKey(moveLeft))
        {
            float m_y = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            if (Input.GetKey(KeyCode.LeftArrow))
                transform.Rotate(new Vector3(), m_y, Space.Self);
        }
    }

    public void Stop()
    {
        transform.Rotate(Vector3.forward, Space.Self);
    }

    void OnGUI()
    {
        double n = 0.2; //Коэффициент трения
        int mas = 1;
        double g = 9.8;
        Vector3 rot = ground.transform.eulerAngles;

        double ugl = rot.z;

        GUILayout.Label(Math.Abs(Math.Round(n * mas * g * Math.Cos(ugl), 2)).ToString() + " H под углом " + ugl); // H - ньютоны 
        GUILayout.Label(Math.Abs(Math.Round(n * mas * g, 2)).ToString() + " H по горизонтальной плоскости");
    }

}

