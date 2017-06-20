using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{

    public GameObject testPlatform;
    public float spawnTime;

    void Start()
    {
        InvokeRepeating("SpawnPlatform", spawnTime, spawnTime);
    }


    void Update()
    {

    }

    void SpawnPlatform()
    {
        Instantiate(testPlatform, new Vector3(0, 5f, 0), Quaternion.identity);
        Instantiate(testPlatform, new Vector3(5f, 5f, 0), Quaternion.identity);
        Instantiate(testPlatform, new Vector3(-5f, 5f, 0), Quaternion.identity);
    }

    
}
