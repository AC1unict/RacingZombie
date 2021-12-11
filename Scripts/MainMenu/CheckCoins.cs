using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckCoins : MonoBehaviour
{
    [SerializeField] Text text;
    [SerializeField] GameObject insert;


    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy)
        {
            text.text = "Coins:" + InsertCoin.instance.getCoins().ToString();
        }

        if(gameObject.activeInHierarchy && InsertCoin.instance.getCoins() == 0)
        {
            insert.SetActive(true);
            if (Input.GetKey("c")) { InsertCoin.instance.addCoins(); }
        }
    }
}
