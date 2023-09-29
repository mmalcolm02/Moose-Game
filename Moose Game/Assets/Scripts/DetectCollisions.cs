using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //override to delete objects on collision
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player")) //collision with player removes life
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);

        }
        if (other.CompareTag("Animal")) //collision between food and animal increases score
        {
            gameManager.AddScore(+1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        
        
    }
}
