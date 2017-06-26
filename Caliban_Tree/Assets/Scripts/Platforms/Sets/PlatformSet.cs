using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlatformSet : MonoBehaviour {



    public GameObject childPlatform;
    public List<GameObject> platforms { get; set;}
    public float mspeed;

    void Start ()
    {
        platforms = new List<GameObject>();
        SetPlatform();
        SetSpeed(mspeed);
	}
	
	
	void Update ()
    {
		if(transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
	}

    void SetSpeed(float speed)
    {
        foreach(GameObject platform in platforms)
        {
            
            platform.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -speed,0);
        }
    }

    public virtual void SetPlatform()
    {
    }
  
}
