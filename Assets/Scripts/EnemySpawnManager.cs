using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        Timer = Time.time + 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < Time.time)
        { //This checks wether real time has caught up to the timer
            Instantiate(enemyPrefab, GenerateSpawnPosition1(), enemyPrefab.transform.rotation);
            Instantiate(enemyPrefab, GenerateSpawnPosition2(), enemyPrefab.transform.rotation);
            Timer = Time.time + 4; //This sets the timer 3 seconds into the future
        }

    }
    Vector3 GenerateSpawnPosition1()
    {
        float xPos = Random.Range(-260, 0);
        float zPos = Random.Range(9, 30);
        Vector3 spawnPos = new Vector3(xPos, enemyPrefab.transform.position.y, zPos);
        return spawnPos;
    }

    Vector3 GenerateSpawnPosition2()
    {
        float xPos = Random.Range(-260, 0);
        float zPos = Random.Range(-30, -10);
        Vector3 spawnPos = new Vector3(xPos, enemyPrefab.transform.position.y, zPos);
        return spawnPos;
    }
}
