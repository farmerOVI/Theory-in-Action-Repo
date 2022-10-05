using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] enemy;
    private float spawnRangeX = 6;
    private float spawnposZ = 0.26f;
    private float startDelay = 2;
    private float spawnInterval = 0.6f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemyPrefab", startDelay, spawnInterval);
        InvokeRepeating("SpawnCollectible", startDelay*3, spawnInterval*3);
    }
    
    //ABSTRACTION
    public void SpawnEnemyPrefab()
    {
        int enemyIndex = 1;
        
      
        for(int i = 0; i < 3; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 7.9f, spawnposZ);
            Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);
        }
        
       
    }

    //ABSTRACTION
    public void SpawnCollectible()
    {
        int enemyIndex = 0;
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 56, spawnposZ);
        Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);
    }
}
