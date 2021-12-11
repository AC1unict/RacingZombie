using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] GameObject cam;
    [SerializeField] GameObject cam2;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Player")
        {
            Timer.istance.setStart(true);
            cam.SetActive(false);
            cam2.SetActive(true);
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player") { cam.SetActive(true); cam2.SetActive(false); }
    }

    
}
