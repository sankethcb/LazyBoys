using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Sanketh Bhat
/// Parent Class for all Platform objects
/// </summary>

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Platform : MonoBehaviour
{

    //temp variable for movepseed

   
    Rigidbody2D rb2D;

	void Start ()
    {
        rb2D = GetComponent<Rigidbody2D>();
       
    }
	
	
	void Update ()
    {
        if (transform.position.y < -10f)
            Destroy(gameObject);
	}

    
}
