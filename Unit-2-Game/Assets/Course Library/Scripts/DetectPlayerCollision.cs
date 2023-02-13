using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayerCollision : MonoBehaviour
{
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
        playerLives -= 1;
        Debug.Log("Lives: " + playerLives);

        if (playerLives == 0)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
