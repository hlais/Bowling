﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	public Vector3  launchVel;
	Rigidbody ball;
	AudioSource ballRollingSound;
    public bool inPlay = false;
	

	// Use this for initialization
	void Start ()
	{
		
		ball = GetComponent<Rigidbody>();
		ball.useGravity = false;
	}

	public void Launch(Vector3 velocity)
	{
        inPlay = true;
        //to keep the ball grounded
		ball.useGravity = true;
		ball.velocity = velocity;

		ballRollingSound = GetComponent<AudioSource>();
		ballRollingSound.Play();

	}

	// Update is called once per frame
	void Update () {
		
	}
}
