using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFermi : MonoBehaviour
{
    [SerializeField] Animator anim;
    int numero=3;
    
    // Update is called once per frame
    void Start()
    {
        if (Random.Range(2, 100) % numero == 1) anim.SetInteger("Tipo", 1);
        else if(Random.Range(2, 100) % numero == 2) anim.SetInteger("Tipo", 2);
    }

    
}
