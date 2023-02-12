using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    int xRange1 = 17;
    int xRange2 = -17;

    int startTime = 2;
    float intervals = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimals", startTime, intervals);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomRange = Random.Range(xRange2, xRange1);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randomRange, 0, 20), animalPrefabs[animalIndex].transform.rotation);

    }

    void pauseGame()
    {
        Time.timeScale = 0;
    }

}
