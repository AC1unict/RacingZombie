using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector3 offset;
    public float followspeed = 10;
    public float lookspeed = 10;
    public int offDefault = 1;
    
    public void LookAtTarget()
    {
        Vector3 _lookDirection = objectToFollow.position - transform.position;
        Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookspeed * Time.deltaTime);
    }

    public void MoveToTarget()
    {
        Vector3 _targetPos = objectToFollow.position +
                            objectToFollow.forward * offset.z +
                            objectToFollow.right * offset.x +
                            objectToFollow.up * offset.y;

        transform.position = Vector3.Lerp(transform.position, _targetPos, followspeed * Time.deltaTime);
    }

    public void FixedUpdate()
    {
        LookAtTarget();
        MoveToTarget();
        if (Input.GetKey("v")) { cambiaVisuale(); }
        

    }

    public void cambiaVisuale()
    {
        if (offDefault==1)
        {
            offset.z = -8; offDefault = 2;
        }
        else if(offDefault == 2)
        {
            offset.z = -10; offDefault = 3;
        }
        else if(offDefault == 3)
        {
            offset.z = -6; offDefault = 1;
        }
    }
}
