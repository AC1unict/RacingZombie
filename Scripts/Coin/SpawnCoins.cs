using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    [SerializeField] private GameObject oro;
    [SerializeField] private GameObject silver;
    [SerializeField] private GameObject bronzo;
    public GameObject[] gold;
    public GameObject[] argento;
    public GameObject[] bronze;
    private int numero;
    public float prob;
    private void Start()
    {
        spawna();
        
    }


    void spawna()
    {
        prob = Random.Range(0.0f, 1.0f);
        if (prob <= 0.1f)
        {
            numero = Random.Range(3, 5);
            gold = new GameObject[numero];

            for (int i = 0; i < numero; i++)
            {
                gold[i] = Instantiate(oro, gameObject.transform);
                gold[i].SetActive(true);
                gold[i].GetComponent<Transform>().Translate(Vector3.forward * i * 3);
            }
        }
        else if (prob > 0.1f && prob <= 0.5f)
        {
            numero = Random.Range(3, 10);
            argento = new GameObject[numero];

            for (int i = 0; i < numero; i++)
            {
                argento[i] = Instantiate(silver, gameObject.GetComponent<Transform>());
                argento[i].SetActive(true);
                argento[i].GetComponent<Transform>().Translate(Vector3.forward * i*3);
            }
        }
        else
        {
            numero = Random.Range(3, 10);
            bronze = new GameObject[numero];

            for (int i = 0; i < numero; i++)
            {
                bronze[i] = Instantiate(bronzo, gameObject.GetComponent<Transform>());
                bronze[i].SetActive(true);
                bronze[i].GetComponent<Transform>().Translate(Vector3.forward * i * 3);
            }
        }
    }

    

}
