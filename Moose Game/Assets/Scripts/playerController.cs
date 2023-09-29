using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20; //boundary of movement
    public float zRangeHigh = 20; //boundary of vertical movement
    public float zRangeLow = -10;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        //horizontal movement input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //player area boundaries
        if (transform.position.x < -xRange) //left boundary
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange) //right boundary
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
            //vertical movement input
            verticalInput = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

            if (transform.position.z < zRangeLow) //high boundary
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRangeLow);
            }
            if (transform.position.z > zRangeHigh) //low boundary
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, zRangeHigh);
            }
    }
}
