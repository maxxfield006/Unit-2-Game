using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    float verticalInput;
    public int speedH;
    public int speedV;
    int xRange = 20;

    public GameObject foodPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //border
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.y);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.y);
        }

        boundries();

        //movement
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speedH);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speedV);

        //food shooter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 1), foodPrefab.transform.rotation);
        }
    }
    
    void boundries()
    {
        if (transform.position.z < -2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
        if (transform.position.z > 10)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
}
