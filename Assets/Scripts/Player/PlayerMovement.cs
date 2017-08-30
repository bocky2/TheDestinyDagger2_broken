using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Setting a variable for the player's rigidbody
    Rigidbody2D rbody;
    //Setting a variable for the player's animator
    Animator anim;
    //Setting a variable for speed
    public float speed;

    // Use this for initialization
    void Start()
    {
        //Getting the player's rigidbody and assigning it to variable
        rbody = GetComponent<Rigidbody2D>();
        //Getting the player's animator and assigning it to variable
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //Move the player upwards
            transform.Translate(Vector2.up * speed);

            //Setting the animation parameters
            anim.SetBool("runU", true);
            anim.SetBool("runD", false);
            anim.SetBool("runR", false);
            anim.SetBool("runL", false);
        }
        //If the down arrow key is pressed
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //Move the player downwards
            transform.Translate(Vector2.down * speed);

            //Setting the animation parameters
            anim.SetBool("runU", false);
            anim.SetBool("runD", true);
            anim.SetBool("runR", false);
            anim.SetBool("runL", false);
        }
        //If the right arrow key is pressed
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //Move the player right
            transform.Translate(Vector2.right * speed);

            //Setting the animation parameters
            anim.SetBool("runU", false);
            anim.SetBool("runD", false);
            anim.SetBool("runR", true);
            anim.SetBool("runL", false);
        }
        //If the left arrow key is pressed
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //Move the player left
            transform.Translate(Vector2.left * speed);

            //Setting the animation parameters
            anim.SetBool("runU", false);
            anim.SetBool("runD", false);
            anim.SetBool("runR", false);
            anim.SetBool("runL", true);
        }
        else
        {
            //If nothing is being pressed, all parameters should equal false
            anim.SetBool("runU", false);
            anim.SetBool("runD", false);
            anim.SetBool("runR", false);
            anim.SetBool("runL", false);
        }

        // -Alternative method
        /*
        //Calculating value that decides whether player is moving or not,
        //by detecting input on the horizontal and vertical axes
        Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"),
                                            Input.GetAxisRaw("Vertical"));
        //Move the player
        rbody.MovePosition(rbody.position + movementVector * Time.deltaTime * speed);
        */
    }
}