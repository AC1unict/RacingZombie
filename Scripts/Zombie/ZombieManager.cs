using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieManager : MonoBehaviour
{
    private float Healt;
    private bool hit;
    private float damage;
    NavMeshAgent agent;
    [SerializeField] Transform target=default;
    
    void Start()
    {
        Healt = 300;
    }

    // Update is called once per frame
    void Update()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agent.destination = target.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Animator>().SetBool("isTrigger", true);
            gameObject.GetComponent<AudioSource>().Play();
            CarDamage.instance.setHealth(10);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Animator>().SetBool("isTrigger", false);
        }
    }

}
