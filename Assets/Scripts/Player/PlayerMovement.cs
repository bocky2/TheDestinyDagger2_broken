using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Setting a variable for the player's rigidbody
    Rigidbody2D rbody;
    //Setting a variable for speed
    public float speed;

    // Use this for initialization
    void Start()
    {
        //Getting the player's rigidbody and assigning it to variable
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the up arrow key is pressed
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            //move the player upwards
            transform.Translate(Vector2.up * speed);
        }
        //if the down arrow key is pressed
        else if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            //move the player downwards
            transform.Translate(Vector2.down * speed);
        }
        //if the right arrow key is pressed
        else if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            //move the player right
            transform.Translate(Vector2.right * speed);
        }
        //if the left arrow key is pressed
        else if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            //move the player left
            transform.Translate(Vector2.left * speed);
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