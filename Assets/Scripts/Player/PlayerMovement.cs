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
        //Calculating value that decides whether play is moving or not,
        //by detecting input on the horizontal and vertical axes
        Vector2 movementVector = new Vector2(Input.GetAxisRaw("Horizontal"),
                                            Input.GetAxisRaw("Vertical"));
        //Move the player
        rbody.MovePosition(rbody.position + movementVector * Time.deltaTime * speed);
    }
}