using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] float tempo;
    GameObject check;

    private void Start()
    {
        check = GameObject.Find("CheckPoint");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            check.GetComponent<AudioSource>().Play();
            Timer.istance.AddTime(tempo);
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
