using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelTow : MonoBehaviour
{
    public float speed = 2f;
    public KeyCode moveRight;
    public KeyCode moveLeft;
    public Transform ground;

    void Start()
    {
    }
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
       
        if (Pressed) Debug.Log("Кнопка нажата");
    }
    void OnGUI()
    {
        double n = 0.02; //Коэффициент трения (ню) (коэффициет пропорциональности)
        int mas = 1;  //масса объекта
        double g = 9.8; //(ускорение свободного падения)  ...Сила реакции опоры (сила упругости) (N - нормальная сила (перпендикулярно поверхности земли).(Н))
        Vector3 rot = ground.transform.eulerAngles;

        double ugl = rot.z;

        GUILayout.Label(Math.Abs(Math.Round(n * mas * g * Math.Cos(ugl), 2)).ToString() + " H под углом " + Math.Round(ugl,2)); // H - ньютоны (mg - сила тяжести, (mas*g)) (Fтр = uN = umgcos(а))
        
        GUILayout.Label(Math.Abs(Math.Round(n * mas * g, 2)).ToString() + " H по горизонтальной плоскости"); //сила трения (скольжения)(качения) покоя + (F = uN, где N = mg, u = ню)
    }

    bool Pressed = false;
    public void onDown()
    {
        Pressed = true;
    }

    public void onUp()
    {
        Pressed = false;
    }
}

