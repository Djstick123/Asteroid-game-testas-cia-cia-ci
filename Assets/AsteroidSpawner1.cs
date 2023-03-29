using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner1 : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnInterval = 2f;

    private void Start()
    {
        
        InvokeRepeating("SpawnAsteroid", 0f, spawnInterval);
    }

    private void SpawnAsteroid()
    {
        
        Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0f, 20f);
        Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);
    }
}
