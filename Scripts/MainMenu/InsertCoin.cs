using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsertCoin : MonoBehaviour
{
    public static InsertCoin instance;
    private float coins;
    [SerializeField] Button newgame;
    Color color;

    private void Start()
    {
        //DontDestroyOnLoad(this);
        coins = 0f;
        color =Color.white;
        instance = this;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.GetComponent<Text>().text = "Press C - Insert Coins: " + Mathf.Ceil(coins).ToString();
        if (Input.GetKey("c")) { coins += 0.1f; gameObject.GetComponent<AudioSource>().Play(); }
        if (Mathf.Ceil(coins) >= 1) newgame.GetComponent<Button>().interactable = true;

        //Debug.Log("Coins:" + Mathf.Ceil(coins));
        
    }

    public float getCoins() { return Mathf.Ceil(coins); }
    public void setCoins() { coins--; }

    public void addCoins() { coins += 0.1f; gameObject.GetComponent<AudioSource>().Play(); }

}
