using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static DontDestroy instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(this);
    }

    
}
