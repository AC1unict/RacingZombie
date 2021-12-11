using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;


public class Opzioni : MonoBehaviour
{
    private bool activate;
    GameObject canvasCoins;
    GameObject canvasHealt;
   [SerializeField] GameObject canvasOptions;
   
    
    void Start()
    {
       
        activate = false;
        canvasCoins = GameObject.Find("Coins");
        canvasHealt = GameObject.Find("HealthText");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("p") && activate==false)
        {
            pausa();
            Thread.Sleep(150);
            activate = true;
        }
        else if(Input.GetKey(KeyCode.Escape) && activate == true)
        {
           
            activate = false;
            canvasCoins.SetActive(true);
            canvasOptions.SetActive(false);
            canvasHealt.SetActive(true);
            Time.timeScale = 1;        
        }
    }

    private void pausa()
    {
        Time.timeScale = 0;
        canvasCoins.SetActive(false);
        canvasOptions.SetActive(true);
        canvasHealt.SetActive(false);
    }

    

}
