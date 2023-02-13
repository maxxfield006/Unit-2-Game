using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    int score = 0;
    int playerLives = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerLives -= 1;
            Debug.Log("Lives: " + playerLives);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Food"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            score += 1;
            Debug.Log("Score: " + score);
        }


    }
}
