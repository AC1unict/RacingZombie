using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    private GameObject[] zombies;

    void Start()
    {
        int n =(int) Random.Range(2, 5);
        zombies = new GameObject[n];

        for(int i = 0; i < n; i++)
        {

            zombies[i] = GameObject.Instantiate(zombie);
            //zombies[i].transform.parent = gameObject.transform;
            zombies[i].transform.position = gameObject.transform.position;
            zombies[i].SetActive(true);
        }

    }

    
}
