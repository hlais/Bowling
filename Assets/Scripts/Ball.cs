using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Vector3  launchVel;
    Rigidbody ball;
    AudioSource ballRollingSound;
    

    // Use this for initialization
    void Start ()
    {
        ball = GetComponent<Rigidbody>();
        ballRollingSound = GetComponent<AudioSource>();

        Launch();

    }

    public void Launch()
    {

        ballRollingSound.Play();
        ball.velocity = launchVel;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
