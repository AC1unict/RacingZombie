using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicVolume : MonoBehaviour
{
    GameObject obj;
    
    
    void Start()
    {
        obj = GameObject.Find("SoundTrack");
    }

    // Update is called once per frame
    void Update()
    {
        obj.GetComponent<AudioSource>().volume = gameObject.GetComponent<Slider>().value;
        //SoundManager.instance.setVolumeSottofondo(gameObject.GetComponent<Slider>().value);
    }

    
}
