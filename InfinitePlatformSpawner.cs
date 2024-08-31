using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; 
    public GameObject obstaclePrefab; 
    public Transform player; 
    public int initialPlatforms = 3; 
    public int numberOfObstaclesPerPlatform = 10; 

    private List<GameObject> platforms = new List<GameObject>();
    private float platformLength = 100f; 

    void Start()
    {
        for (int i = 0; i < initialPlatforms; i++)
        {
            SpawnPlatform(i * platformLength);
        }
    }

    void Update()
    {
        if (player.position.z > platforms[platforms.Count - 1].transform.position.z - platformLength * 0.6f)
        {
            SpawnPlatform(platforms[platforms.Count - 1].transform.position.z + platformLength);
            RemoveOldPlatform();
        }
    }

    void SpawnPlatform(float zPosition)
    {
        GameObject newPlatform = Instantiate(platformPrefab, new Vector3(0, 0, zPosition), Quaternion.identity);
        platforms.Add(newPlatform);
        
        SpawnObstacles(newPlatform.transform.position);
    }

    void RemoveOldPlatform()
    {
        Destroy(platforms[0]);
        platforms.RemoveAt(0);
    }

    void SpawnObstacles(Vector3 platformPosition)
    {
        for (int i = 0; i < numberOfObstaclesPerPlatform; i++)
        {
            float randomX = Random.Range(-7f, 7f);
            float randomZ = Random.Range(0, platformLength);

            Vector3 spawnPosition = new Vector3(randomX, 5f, platformPosition.z + randomZ);
            Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
        }
    }
}
