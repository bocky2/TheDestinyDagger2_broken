using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour
{
    //Set variable for time passed
    private float timePassed = 0;

	// Update is called once per frame
	void Update ()
    {
        timePassed += Time.deltaTime;
        //When 6 seconds have passed
		if (timePassed >= 5)
        {
            //Switch to the menu
            SceneManager.LoadScene("menu");
        }
	}
}
