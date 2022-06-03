using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public Transform player;
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
    }
}