using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    //Reference to the Rigidbody2D
    public Rigidbody2D bullet_rb2D;
    //Bullet Force
    public float bulletForce = 200f;
    //Is the player facing right
    private bool isFacingLeft;
    //Bullet life
    public float bulletTime = 1f;

    void Awake()
    {
        bullet_rb2D = GetComponent<Rigidbody2D>();

        isFacingLeft = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isFacingLeft;

        if (isFacingLeft)
            bullet_rb2D.AddForce(new Vector2(-bulletForce, 0));
        else
            bullet_rb2D.AddForce(new Vector2(bulletForce, 0));

        Destroy(gameObject, bulletTime);

    }
}
