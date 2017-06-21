using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject defaultset;
    public GameObject diagonalset;
    public float spawnTime;
    bool spawnwhat = false;

    void Start()
    {
        InvokeRepeating("SpawnPlatform", 1, spawnTime);
    }


    void Update()
    {

    }

    void SpawnPlatform()
    {
        if (!spawnwhat)
        {
            Instantiate(defaultset, new Vector3(0, 7.5f, 0), Quaternion.identity);
            spawnwhat = true;
        }
        else
        {
            Instantiate(diagonalset, new Vector3(0, 7.5f, 0), Quaternion.identity);
            spawnwhat = false;
        }

    }

    
}
