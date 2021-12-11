using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    //[SerializeField] GameObject PUp;

    private void Start()
    {
        //PUp.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            switch (gameObject.layer)
            {
                case 12:
                    StartCoroutine(Nitro(other));
                    other.gameObject.GetComponent<CarDriver>().drag /= 15;
                    //if (PUp.activeInHierarchy) PUp.SetActive(false);
                    break;
                
                case 13: ResetHealt(other); break;
            }

            Destroy(gameObject);
        }
    }

    private IEnumerator Nitro(Collider other)
    {
        
        other.gameObject.GetComponent<CarDriver>().drag *= 20;
        PowerManager.instance.gameObject.GetComponent<AudioSource>().clip = PowerManager.instance.nitro;
        PowerManager.instance.gameObject.GetComponent<AudioSource>().Play();
        //PUp.SetActive(true);
        yield return new WaitForSecondsRealtime(4);
    }

    private void ResetHealt(Collider other)
    {
        other.gameObject.GetComponent<CarDamage>().setHealt();
        PowerManager.instance.gameObject.GetComponent<AudioSource>().clip = PowerManager.instance.healt;
        PowerManager.instance.gameObject.GetComponent<AudioSource>().Play();
    }

}
