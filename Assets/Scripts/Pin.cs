using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    public float standingThreshold = 5f;


    private void Start()
    {


    }
    private void Update()
    {

    }
    public bool IsStanding()
    {
        float tiltX = (transform.eulerAngles.x < 180f) ? transform.eulerAngles.x : 360 - transform.eulerAngles.x;
        float tiltZ = (transform.eulerAngles.z < 180f) ? transform.eulerAngles.z : 360 - transform.eulerAngles.z;
        if (tiltX > standingThreshold || tiltZ > standingThreshold)
        {
            return false;
        }
        return true;


        //public bool IsStanding()
        //{
        //    Vector3 rotationInEuler = transform.rotation.eulerAngles;
        //    float tiltInX = Mathf.Abs(rotationInEuler.x);
        //    float tiltInZ = Mathf.Abs(rotationInEuler.z);

        //    if (tiltInX < standingThreshold && tiltInZ < standingThreshold)
        //    {
        //        return true;
        //    }

        //    return false;
        //}

    }
}
