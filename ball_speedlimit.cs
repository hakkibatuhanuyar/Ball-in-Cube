using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_speedlimit : MonoBehaviour {

    public float Maxspeed;

    private void FixedUpdate()
    {
        if(GetComponent<Rigidbody>().velocity.magnitude > Maxspeed)
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity.normalized * Maxspeed;

        }


    }
}

