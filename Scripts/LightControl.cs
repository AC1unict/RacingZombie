using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    public bool on;
    void Start()
    {
        gameObject.GetComponent<Light>().intensity = 0;
        on = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            gameObject.GetComponent<Light>().intensity = 1;
        }
        else {
            gameObject.GetComponent<Light>().intensity = 0;
        }


        if (Input.GetKey("h")) { on_off(); LightOn(); }

        }

    private bool on_off()
    {
        return on=!on;
    }

    private void LightOn()
    {
       if (gameObject.tag == "Faro" && on==true)
            {
                gameObject.GetComponent<Light>().intensity = 10;
            }
    }
    
}
