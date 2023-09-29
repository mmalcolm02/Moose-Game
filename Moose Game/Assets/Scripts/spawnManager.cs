using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosZ = 20;
    private float spawnPosZMin = -10;
    private float spawnRangeX = 20;
    private float startDelay = 2;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

       
    }

    void SpawnRandomAnimal()
    {
 
        int animalIndex = Random.Range(0, animalPrefabs.Length);

            Vector3 spawnPosTop = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPosTop, animalPrefabs[animalIndex].transform.rotation);
  
            Vector3 spawnPosRight = new Vector3(spawnRangeX, 0, Random.Range(spawnPosZMin, spawnPosZ));
            Instantiate(animalPrefabs[animalIndex], spawnPosRight, Quaternion.Euler(0, -90, 0));
  
            Vector3 spawnPosLeft = new Vector3(-spawnRangeX, 0, Random.Range(spawnPosZMin, spawnPosZ));
            Instantiate(animalPrefabs[animalIndex], spawnPosLeft, Quaternion.Euler(0, 90, 0));

        
    }
}
