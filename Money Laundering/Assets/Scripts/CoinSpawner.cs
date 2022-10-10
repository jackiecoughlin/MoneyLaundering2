using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform[] spawns;
    private Transform spawn;


    // Start is called before the first frame update
    void Awake()
    {
          for (int i = 0; i < 5; i++){
            spawn = spawns[i];
            Instantiate(coinPrefab, spawn.position, Quaternion.identity);
          }
    }

    // Update is called once per frame
    /*void Update()
    {

    }*/
}
