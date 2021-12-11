using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCoins : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {

        if(other && other.gameObject.tag == "Coin")
        {
            switch (other.gameObject.layer)
            {
                case 8: CoinManager.istance.addCoins(5); CoinManager.istance.GetComponent<AudioSource>().Play(); break; 
                case 9: CoinManager.istance.addCoins(2); CoinManager.istance.GetComponent<AudioSource>().Play(); break;
                case 10: CoinManager.istance.addCoins(1);CoinManager.istance.GetComponent<AudioSource>().Play(); break;

            }
            other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }

    
    

}
