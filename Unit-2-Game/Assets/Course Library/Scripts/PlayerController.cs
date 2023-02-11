using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalInput;
    public int speed;
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

        //movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //food shooter
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
