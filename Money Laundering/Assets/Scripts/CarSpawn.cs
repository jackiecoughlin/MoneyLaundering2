using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{

    public GameObject carPrefab;
    public Transform spawn;

    public float spawnRangeStart;
    public float spawnRangeEnd;
    private float timeToSpawn;
    private float spawnTimer = 0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        timeToSpawn = Random.Range(spawnRangeStart, spawnRangeEnd);
        spawnTimer += 0.01f;
        if (spawnTimer >= timeToSpawn){
          spawnCar();
          spawnTimer = 0f;
        }
    }

    void spawnCar(){
      Instantiate(carPrefab, spawn.position, Quaternion.identity);
    }
}
