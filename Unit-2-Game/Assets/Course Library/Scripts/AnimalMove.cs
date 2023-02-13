using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;
using UnityEngine.UI;

public class AnimalMove : MonoBehaviour
{
    float speed = 8f;
    float aggSpeed = 15f;
    int bottomBound = -15;
    int rightBound = 20;

    bool debug = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -rightBound)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);


        stopSpawning();
    }

    public void stopSpawning()
    {
        if (transform.position.z < -5 && debug)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
            debug = false;
        }
    }
}
