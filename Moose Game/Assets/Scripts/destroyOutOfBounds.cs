using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    //object boundaries
    private float topBound = 30;
    private float lowerBound = -20;
    private float leftBound = -30;
    private float rightBound = 30;
    private int lives = 3;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //if an object leaves player view it is destroyed
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //if object passes player it is destroyed and displays game over
            lives--;
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }
    }
}
