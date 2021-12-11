using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager:MonoBehaviour{

    public static CoinManager istance;
    public int coins;
    [SerializeField] Text text;
    
    private void Start()
    {
        istance = this;
        coins = getCoins();
    }

    private void Update()
    {
        text.text = coins.ToString();
    }


    public void addCoins(int value)
    {
        coins += value;
    }
    
    public void saveCoins()
    {
        PlayerPrefs.SetInt("Coins", coins);
        
    }

    public int getCoins()
    {
       return PlayerPrefs.GetInt("Coins");
       
    }

    
    

}
