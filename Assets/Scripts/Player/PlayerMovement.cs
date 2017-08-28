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
        //if the up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //move the player upwards
            transform.Translate(Vector2.up * speed);

            anim.SetBool("runU", true);
            anim.SetBool("runD", false);
            anim.SetBool("runR", false);
            anim.SetBool("runL", false);
        }
        //if the down arrow key is pressed
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //move the player downwards
            transform.Translate(Vector2.down * speed);

            anim.SetBool("runU", false);
            anim.SetBool("runD", true);
            anim.SetBool("runR", false);
            anim.SetBool("runL", false);
        }
        //if the right arrow key is pressed
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //move the player right
            transform.Translate(Vector2.right * speed);

            anim.SetBool("runU", false);
            anim.SetBool("runD", false);
            anim.SetBool("runR", true);
            anim.SetBool("runL", false);
        }
        //if the left arrow key is pressed
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //move the player left
            transform.Translate(Vector2.left * speed);

            anim.SetBool("runU", false);
            anim.SetBool("runD", false);
            anim.SetBool("runR", false);
            anim.SetBool("runL", true);
        }
        else
        {
            anim.SetBool("runU", false);
            anim.SetBool("runD", false);
            anim.SetBool("runR", false);
            anim.SetBool("runL", false);
        }

        // -Alternative method \/
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