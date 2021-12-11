using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundEffect : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        SoundManager.instance.setEffettiSonori(gameObject.GetComponent<Slider>().value);
    }
}
