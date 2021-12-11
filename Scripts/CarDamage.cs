using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarDamage : MonoBehaviour
{

    private float healt;
    public static CarDamage instance;
    [SerializeField] Text printHealt;
    [SerializeField] GameObject danno;

    private void Start()
    {
        healt = 100;
        instance = this;
        danno.SetActive(false);
    }

    private void Update()
    {
        printHealt.text = "HEALTH:" + Mathf.Ceil(healt).ToString();
        if (healt <= 30) danno.SetActive(true);
    }


    private void OnTriggerEnter(Collider other){

        if (other && other.gameObject.tag=="Obstacle")
        {
            if(healt>0) healt -=Mathf.Abs( gameObject.GetComponent<CarDriver>().getSpeed()/healt);
        }
    }

    public float getHealt() { return healt; }

    public void setHealt() { healt = 100; }

    public void setHealth(float danno) { if(healt>0) healt -= danno; }
    
    
}
