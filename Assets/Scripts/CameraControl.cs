﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Ball ball;
	// Use this for initialization

	private Vector3 offset;
	void Start () {

		offset = transform.position - ball.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (transform.position.z <= 1829f)
		{
			transform.position = ball.transform.position + offset;
		}

		
		
	}
}
