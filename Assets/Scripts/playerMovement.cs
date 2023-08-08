using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D playerRigidbody2d;
    public float speed;

    public GameObject gameWonCanvas;
    public GameObject gameLooseCanvas;

    private void Start()
    {
       // Time.timeScale = 1.0f;
    }
    void Update()
    {
        
        if(Input.GetAxis("Horizontal") > 0 && Input.GetKey(KeyCode.Space) == false)
        {
            playerRigidbody2d.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetAxis("Horizontal") < 0 && Input.GetKey(KeyCode.Space) == false)
        {
            playerRigidbody2d.velocity = new Vector2(-speed, 0f);
        }
        else if (Input.GetAxis("Vertical") > 0 && Input.GetKey(KeyCode.Space) == false)
        {
            playerRigidbody2d.velocity = new Vector2(0f, speed);
        }
        else if (Input.GetAxis("Vertical") < 0 && Input.GetKey(KeyCode.Space) == false)
        {
            playerRigidbody2d.velocity = new Vector2(0f, -speed);
        }
        else if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            playerRigidbody2d.velocity = new Vector2(0f, 0f);
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Door")    // for checking tag other.tag=="tagName" or collision.gameObject.comparetag("tagName") is also useable.
        {
            Debug.Log("Level Compelete!");
            gameWonCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
         else if (collision.tag == "Enemy")
        {
            Debug.Log("You Loose!");
            gameLooseCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.compare == "Enemy")
    //    {
    //        Debug.Log("You Loose!");
    //    }
    //}

}
