using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlloRibaltato : MonoBehaviour
{
    private bool ribaltato;
    GameObject car;
    
    void Start()
    {
        ribaltato = false;
        car = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (ribaltato)
        {
            if (Input.GetKey("r"))
            {
                car.GetComponent<Transform>().Rotate(Vector3.forward * 50);
            } 
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Track")
        {
            ribaltato = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Track") ribaltato = false;
    }
}
