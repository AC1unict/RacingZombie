using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundEffects : MonoBehaviour
{
    GameObject obj;
    void Start()
    {
        obj = GameObject.Find("RainPrefab");
    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<AudioSource>().volume = gameObject.GetComponent<Slider>().value;
        
    }
}
