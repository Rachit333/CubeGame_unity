using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab; 
    public int numberOfObstacles = 20; 
    public float groundWidth = 15f; 
    public float groundLength = 100f; 
    public float spawnHeight = 0.5f; 

    void Start()
    {
        SpawnObstacles();
    }

    void SpawnObstacles()
    {
        for (int i = 0; i < numberOfObstacles; i++)
        {
            float randomX = Random.Range(-groundWidth / 2, groundWidth / 2);
            float randomZ = Random.Range(0, groundLength);

            Vector3 spawnPosition = new Vector3(randomX, spawnHeight, randomZ);
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
