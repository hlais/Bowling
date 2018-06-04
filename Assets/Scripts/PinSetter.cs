using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PinSetter : MonoBehaviour {

	public Text standingDisplay;
	private bool ballEnteredBox = false;
	
	void Update () {

			
		standingDisplay.text = CountStanding().ToString();
		
	}
	int CountStanding()
	{
		int standingPin = 0;

		foreach (Pin pin in GameObject.FindObjectsOfType<Pin>()) 
		{
			if (pin.IsStanding())
			{  
				standingPin++;
			}
		}
		return standingPin;
	
	}

    //activate red textwhen ball enters
	private void OnTriggerEnter(Collider ball)
	{
		GameObject thingHit = ball.gameObject;

		if (thingHit.GetComponent<Ball>())
		{
			ballEnteredBox = true;
			standingDisplay.color = Color.red;
		}
	}
    //destroys pins when they leave 
	private void OnTriggerExit(Collider pin)
	{
        GameObject thingLeaving = pin.gameObject;
        

        //check of pins leaving. 
        if (thingLeaving.GetComponent<Pin>())
        {
            Destroy(thingLeaving);


        }	
	}
}
