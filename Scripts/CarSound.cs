using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSound : MonoBehaviour
{
    AudioSource fermo;
    

    [SerializeField] AudioClip stop;
    [SerializeField] AudioClip drag;
    [SerializeField] AudioClip deceleration;
    //[SerializeField] AudioClip speed;


    GameObject car;
    void Start()
    {
       fermo= gameObject.AddComponent<AudioSource>();
       car = GameObject.FindGameObjectWithTag("Player");
        fermo.playOnAwake = false;
        fermo.spatialBlend = 1;

    }

    // Update is called once per frame
    void Update()
    {
        f();
        acc();
    }

    public void f()
    {
        if(car.GetComponent<CarDriver>().getSpeed()==0)
        {
            
            fermo.loop = true;
            fermo.clip = stop;
            fermo.Play();
        }
    }

    public void acc()
    {
        if (car.GetComponent<CarDriver>().getSpeed() > 0 && car.GetComponent<CarDriver>().getSpeed()<500)
        {

            fermo.loop = true;
            fermo.clip = drag;
            fermo.Play();

        }

    }

    public void dec()
    {
        if(car.GetComponent<CarDriver>().getM_vertical()>0 && car.GetComponent<CarDriver>().getM_vertical() < 1)
        {
            fermo.loop = true;
            fermo.clip = deceleration;
            fermo.Play();
        }
    }


}
