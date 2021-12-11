using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCoin : MonoBehaviour
{
     void Update()
    {
        gameObject.GetComponent<Transform>().Rotate(Vector3.right*2);
    }
}
