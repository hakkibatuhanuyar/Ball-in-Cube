using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//-------------CODE TO ROTATE THE CUBE-------------//


public class newcube_rotate : MonoBehaviour
{

    public float rotspeed = 1;

    void OnMouseDrag()
    {
        float rotx = Input.GetAxis("Mouse X") * rotspeed * Mathf.Deg2Rad;

        float roty = Input.GetAxis("Mouse Y") * rotspeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotx, 0);

        transform.Rotate(Vector3.right, roty, 0);

    }

}








