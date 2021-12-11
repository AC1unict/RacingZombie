using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriver : MonoBehaviour
{
    private float m_horizontal;
    private float m_vertical;
    private float m_space;
    private float m_steerAngle;
    private bool check = true;

    public WheelCollider frontWheelLeft, frontWheelRight;
    public WheelCollider rearWheelLeft, rearWheelRight;

    public Transform frontWheelLeft_T, frontWheelRight_T;
    public Transform rearWheelLeft_T, rearWheelRight_T;
    public float maxsteerangle = 35;
    public float drag ;
    public float brak = -1000000000f;
    public float attr = -250f;



    public void getInput()
    {
        if (check) {
            m_horizontal = Input.GetAxis("Horizontal");
            m_vertical = Input.GetAxis("Vertical");
            m_space = Input.GetAxis("Jump");
        } else if (!check)
        {
            m_vertical = 0;
        }

        //Debug.Log("vertical:" + m_vertical);
    }

    private void Steer()
    {
        m_steerAngle = maxsteerangle * m_horizontal;
        frontWheelLeft.steerAngle = m_steerAngle;
        frontWheelRight.steerAngle = m_steerAngle;


    }

    private void accelerate()
    {
        rearWheelLeft.motorTorque = m_vertical * drag;
        rearWheelRight.motorTorque = m_vertical * drag;
        if (m_vertical < 1 && m_vertical >= 0)
        {
            rearWheelLeft.brakeTorque -= attr;
            rearWheelRight.brakeTorque -= attr;
        }

    }
    private void brake()
    {

        frontWheelLeft.brakeTorque = m_space * brak;
        frontWheelRight.brakeTorque = m_space * brak;
        rearWheelLeft.brakeTorque = m_space * brak;
        rearWheelRight.brakeTorque = m_space * brak;

    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontWheelLeft, frontWheelLeft_T);
        UpdateWheelPose(frontWheelRight, frontWheelRight_T);
        UpdateWheelPose(rearWheelLeft, rearWheelLeft_T);
        UpdateWheelPose(rearWheelRight, rearWheelRight_T);
    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = transform.position;
        Quaternion _quat = transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);
        _transform.position = _pos;
        _transform.rotation = _quat;
    }

    private void FixedUpdate()
    {
        getInput();
        Steer();
        brake();
        accelerate();
        UpdateWheelPoses();
        //Debug.Log(m_vertical * drag);
        if (Input.GetKey("z") && m_vertical * drag == 0)
        {
            gameObject.GetComponent<Transform>().Translate(Vector3.forward * 2 * Time.deltaTime);
        }
    }

    public void setCheck() { check = false; }
    public float getSpeed() { return m_vertical * drag; }

    public float getM_vertical() { return m_vertical; }

}
