using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Speed of the Player
    public float playerSpeed = 10f;
    //Direction Player is facing
    public bool isFacingLeft = false;
    //Reference to the Player's Rigidbody
    private Rigidbody2D playerBody;
    //Reference to the Player's Animator
    [SerializeField]
    private Animator playerAnimator;
    
    //Player Grounded?
    bool isGrounded = false;
    //Transform at Player's feet
    public Transform groundCheck;
    float groundRadius = 0.1f;
    //Jump Force of the Player
    public float playerJumpForce = 700f;
    //LayerMask for the ground
    public LayerMask groundMask;
    //Double Jump Counter
    bool doubleJump = false;


	// Use this for initialization
	void Start () {
        playerBody = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate () {
        //Get move direction
        float move = Input.GetAxis("Horizontal");

        playerAnimator.SetFloat("Speed", Mathf.Abs(move));

        //Move the player
        if(isGrounded)
            playerBody.velocity = new Vector2(move * playerSpeed, playerBody.velocity.y);
        else
            playerBody.velocity = new Vector2(move * playerSpeed/2, playerBody.velocity.y);

        //Flip player if move is positive and player is facing the left
        if (move > 0 && isFacingLeft)
        {
            flipPlayer();
        } 
        else if (move < 0 && !isFacingLeft)
        {
            flipPlayer();
        }

        //Did the ground transform hit the groundMask
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);
        
        //Reset doubleJump
        if(isGrounded)
        {
            doubleJump = false;
        }
	}

    void Update()
    {   
        //If the player is grounded
        if ((isGrounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space))
        {   
            //Add playerJumpForce to the y axis of the playerBody
            playerBody.AddForce(new Vector2(0, playerJumpForce));

            //Set doubleJump to true if player double jumped
            if(!doubleJump && !isGrounded)
            {
                doubleJump = true;
            }
        }
    }


    //Function to flip the sprite
    void flipPlayer()
    {
        //Flip the player
        isFacingLeft = !isFacingLeft;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale; 
    }

}
