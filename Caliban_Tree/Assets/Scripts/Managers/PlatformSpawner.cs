using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject defaultset;
    public GameObject altset;
    public float spawnTime;
    bool switchSpawn;


    void Start()
    {
        switchSpawn = false;
        InvokeRepeating("SpawnPlatform", 1, spawnTime);
       
    }


    void Update()
    {

    }

    void SpawnPlatform()
    {
        if (!switchSpawn)
        {
            Instantiate(defaultset, new Vector3(0, 7f, 0), Quaternion.identity);
            switchSpawn = true;

        }
        else
        {
            Instantiate(altset, new Vector3(0, 7f, 0), Quaternion.identity);
            switchSpawn = false;
        }

    }

    
}
