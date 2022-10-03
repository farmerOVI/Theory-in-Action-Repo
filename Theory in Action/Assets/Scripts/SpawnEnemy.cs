using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    private float spawnRangeX = 6;
    private float spawnposZ = 0.26f;
    private float startDelay = 2;
    private float spawnInterval = 2.6f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemyPrefab", startDelay, spawnInterval);
    }
    
    public void SpawnEnemyPrefab()
    {
        int enemyIndex = Random.Range(0, 2);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 56, spawnposZ);
        Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);
    }
}
