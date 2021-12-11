using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SendData : MonoBehaviour
{

    [SerializeField] InputField input;

    public void creaNodo()
    {
        string nome = input.text;
        int val = CoinManager.istance.coins;

        Ranking.instance.addRank(nome, val);
        Debug.Log("Nodo creato");
    }

    public void saveRank()
    {
        Ranking.instance.saveRank();
    }

    public void sort()
    {
        Ranking.instance.sortList();
    }


}
