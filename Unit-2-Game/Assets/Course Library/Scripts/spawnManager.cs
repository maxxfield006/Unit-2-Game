using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] aggressiveAnimalPrefabs;
    int xRange = 17;

    float zRange1 = 0.4f;
    float zRange2 = 15f;

    int startTime = 2;
    float intervals = 2f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnAnimalsVertical", startTime, intervals);
        InvokeRepeating("spawnAnimalsHorizontal", startTime, intervals);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnAnimalsVertical()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        int randomRange = Random.Range(-xRange, xRange);
        Instantiate(animalPrefabs[animalIndex], new Vector3(randomRange, 0, 20), animalPrefabs[animalIndex].transform.rotation);

    }
    void spawnAnimalsHorizontal()
    {
        int aggAnimalIndex = Random.Range(0, aggressiveAnimalPrefabs.Length);
        float randomSpawnRange = Random.Range(zRange1, zRange2);
        Instantiate(aggressiveAnimalPrefabs[aggAnimalIndex], new Vector3(-19, 0, randomSpawnRange), aggressiveAnimalPrefabs[aggAnimalIndex].transform.rotation);
    }

    void pauseGame()
    {
        Time.timeScale = 0;
    }

}
