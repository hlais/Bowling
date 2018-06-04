using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{

    public float standingThreshold = 5f;

    public bool IsStanding()
    {
        float newX = 270f - transform.rotation.eulerAngles.x;
        float tiltX = (transform.eulerAngles.x < 180f) ? newX : 360 - newX;
        float tiltZ = (transform.eulerAngles.z < 180f) ? transform.eulerAngles.z : 360 - transform.eulerAngles.z;
        if (tiltX < standingThreshold && tiltZ < standingThreshold)
        {
            return false;
        }
        return true;
    }
}
