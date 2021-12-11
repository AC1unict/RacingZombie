using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButton : MonoBehaviour
{
    [SerializeField] GameObject menu;
    // Update is called once per frame
    private void Update()
    {

        if (InsertCoin.instance.getCoins() == 0)
        {
            gameObject.GetComponent<Button>().interactable = false;
            menu.GetComponent<Button>().interactable = true;
        }

        else if (InsertCoin.instance.getCoins() > 0)
        {
            gameObject.GetComponent<Button>().interactable = true;
            menu.GetComponent<Button>().interactable = false;
        }
        //Debug.Log(InsertCoin.instance.getCoins());
    }


}
