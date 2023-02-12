using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalMove : MonoBehaviour
{
    float speed = 15f;
    int bottomBound = -15;

    bool debug = true;

    public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
        }

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        stopSpawning();
    }

    void stopSpawning()
    {
        if (transform.position.z < -5 && debug)
        {
            Time.timeScale = 0;
            Debug.Log("GAME OVER");
            debug = false;
            gameOver.text = "GAME OVER";
        }
    }
}
