using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject defaultset;
    public float spawnTime;


    void Start()
    {
        InvokeRepeating("SpawnPlatform", 1, spawnTime);
    }


    void Update()
    {

    }

    void SpawnPlatform()
    {

        Instantiate(defaultset, new Vector3(0, 7f, 0), Quaternion.identity);

    }

    
}
