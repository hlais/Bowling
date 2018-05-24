using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Ball))]
public class DragLaunch : MonoBehaviour
{
	private Ball ball;
	private Vector3 dragStart, dragEnd;
	private float startTime, endTime;
	
	// Use this for initialization
	void Start ()
	{
		ball = GetComponent<Ball>();
		
	}
	public void DragStart()
	{
		//capture time & position of drag start
		startTime = Time.time;
		dragStart = Input.mousePosition;
	}
	public void DragEnd()
	{
		dragEnd = Input.mousePosition;
		endTime = Time.time;

		float dragDuration = endTime - startTime;

		float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;
		//y was used as the axis is on a 2D canvas
		float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;

		Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeedZ);

		ball.Launch(launchVelocity);

	}
	public void MoveStart(float amount)
	{
        if (ball.inPlay == false)
        {
            ball.transform.Translate(amount, 0, 0);
        }
	}
}
