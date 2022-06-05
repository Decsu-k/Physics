using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PlayerMove : MonoBehaviour
{
    public class Position
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
        public DateTime Date { get; set; }
    }
    public Transform player;
    public List<Position> positions = new List<Position>();
    void Start()
    {
        player.position = new Vector3(0, 2, 0);
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Respawn")
        {
            SceneManager.LoadScene(0);
        }
    }
    void OnGUI()
    {
        GUILayout.Label(transform.position.ToString());

        positions.Add(new Position()
        {
            Date = DateTime.Now,
            x = transform.position.x,
            y = transform.position.y,
            z = transform.position.z,
        });

        var lastpos = positions[positions.Count - 2];

        positions.Remove(lastpos);

        print(positions[positions.Count - 1].x);
        print(positions[positions.Count - 1].y);
        print(positions[positions.Count - 1].z);
        print(positions[positions.Count - 1].Date);
    }
}
