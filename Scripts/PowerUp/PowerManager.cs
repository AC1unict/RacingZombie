using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerManager : MonoBehaviour
{
    public static PowerManager instance;
    [SerializeField] public AudioClip nitro;
    [SerializeField] public AudioClip healt;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    
}
