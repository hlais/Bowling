using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Collections;
using UnityEngine;

public class PinSetter : MonoBehaviour {

	public Text standingDisplay;
	// Use this for initialization
	void Start () {

	  
		
	}
	
	// Update is called once per frame
	void Update () {

		standingDisplay.text = CountStanding().ToString();
		
	}
	int CountStanding()
	{
		int standingPin = 10;

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
