using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class PinSetter : MonoBehaviour {

	public Text standingDisplay;

	void Update () {

        print(CountStanding());
            
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
}
