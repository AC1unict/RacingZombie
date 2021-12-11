using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicOptions : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        SoundManager.instance.setVolumeSottofondo(gameObject.GetComponent<Slider>().value);
    }
}
