using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private GameObject sottofondo;
    private GameObject windZone;
    private GameObject checkpoints;
    private GameObject powerup;

    void Start()
    {
        instance = this;
        sottofondo = GameObject.Find("Sottofondo");
        windZone = GameObject.Find("WindZone");
        checkpoints = GameObject.Find("CheckPoint");
        powerup = GameObject.Find("PowerUpManager");
    }

    public void setVolumeSottofondo(float volume)
    {
       sottofondo.GetComponent<AudioSource>().volume=volume;
    }

    public void setEffettiSonori(float volume)
    {
        CoinManager.istance.GetComponent<AudioSource>().volume = volume;
        windZone.GetComponent<AudioSource>().volume = volume;
        checkpoints.GetComponent<AudioSource>().volume = volume;
        powerup.GetComponent<AudioSource>().volume = volume;

    }



    
}
