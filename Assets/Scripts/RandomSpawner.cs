using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject enemyPrefab;
    public float spawnInterval = 5f;
    private float timeUntilSpawn = 0;



    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            timeUntilSpawn = spawnInterval;
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        int randSpawPoint = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[randSpawPoint].position, transform.rotation);
    }

} 