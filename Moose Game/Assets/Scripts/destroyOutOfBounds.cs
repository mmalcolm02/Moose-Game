using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    //object boundaries
    private float topBound = 30;
    private float lowerBound = -20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if an object leaves player view it is destroyed
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            //if object passes player it is destroyed and displays game over
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
