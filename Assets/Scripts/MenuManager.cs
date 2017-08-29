using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //Set variable for the dagger
    public Image dagger;
    //Set variable to decide what menu option the user is selecting
    private int menuOp = 0;
    //Set variable for the dagger's position
    private Vector2 dagPos;
	
	// Update is called once per frame
	void Update ()
    {
        //If the up arrow key is pressed
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            //Add one to the menu option (changing what option the user has selected)
            menuOp += 1;
            
        }
        //If the down arrow key is pressed
        else if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            //Subtract one from the menu option
            menuOp -= 1;
        }

        //If the menu option exceeds 2
        if (menuOp >= 3)
        {
            //The menu option should equal 0
            menuOp = 0;
        }
        //If the menu option is below 0
        if (menuOp <= -1)
        {
            //The menu option should equal 2
            menuOp = 2;
        }

        //If the user has selected the first option
        if (menuOp == 0)
        {
            //Set the dagger's position to next to the first option
            dagPos = new Vector2(310, 257);
        }
        //If the user has selected the second option
        if (menuOp == 1)
        {
            //Set the dagger's position to next to the second option
            dagPos = new Vector2(300, 197);
        }
        //If the user has selected the third option
        if (menuOp == 2)
        {
            //Set the dagger's position to next to the third option
            dagPos = new Vector2(345, 100);
        }

        //Move the dagger to the position set
        dagger.rectTransform.position = dagPos;
	}
}
