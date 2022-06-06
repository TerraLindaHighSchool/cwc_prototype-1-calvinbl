using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    public GameObject[] ObstaclePrefabs;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Update()
    {
        
    }
    void SpawnRandomObstacle()
    {
        int ObstacleIndex = Random.Range(0, ObstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(ObstaclePrefabs[ObstacleIndex], spawnPos, ObstaclePrefabs[ObstacleIndex].transform.rotation);
    }

}
