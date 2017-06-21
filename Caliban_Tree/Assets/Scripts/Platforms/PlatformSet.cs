using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSet : MonoBehaviour {

    public Rigidbody2D[] platforms;
    public float mspeed;

    void Start ()
    {
        platforms = GetComponentsInChildren<Rigidbody2D>();
        SetSpeed(mspeed);
	}
	
	
	void Update ()
    {
		
	}

    void SetSpeed(float speed)
    {
        foreach(Rigidbody2D platform in platforms)
        {
            platform.velocity = new Vector3(0, -speed,0);
            Debug.Log(platform.velocity);
        }
    }
}
