using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] spawnGameObjects;
   
    [SerializeField] private float spawnRate = 5f;

    [SerializeField] private Transform[] spawnPositions;

    private TimeManager timeManager;

    private float nextSpawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        timeManager = FindObjectOfType<TimeManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad > nextSpawnTime && timeManager.gameOver == false && timeManager.oyunBitti == false)
        {
            nextSpawnTime += spawnRate;
            //Instantiate(coinPrefab, transform.position, transform.rotation);
            SpawnObject(spawnGameObjects[RandomObjectNumber()], spawnPositions[RandomSpawnNumber()]);
            print("Spawn");
        }
        
    }

    private void SpawnObject(GameObject objectToSpawn, Transform newTransform)
    {
        Instantiate(objectToSpawn, newTransform.position, newTransform.rotation);
    }
    private int RandomSpawnNumber()
    {
        return Random.Range(0,spawnPositions.Length);
    }
    private int RandomObjectNumber()
    {
        return Random.Range(0, spawnGameObjects.Length);
    }
}
