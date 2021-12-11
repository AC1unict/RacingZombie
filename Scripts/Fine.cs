using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fine : MonoBehaviour
{
    [SerializeField] GameObject camera;
    [SerializeField] GameObject canvasFine;
    [SerializeField] GameObject coinsFine;
    private GameObject main;

    private void Start()
    {
        main = GameObject.Find("Main Camera");
        camera.SetActive(false);
        
        canvasFine.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            main.SetActive(false);
            camera.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CarDriver>().setCheck();
            camera.GetComponent<Transform>().Translate(Vector3.up * 10 * Time.deltaTime);
            canvasFine.SetActive(true);
            Timer.istance.setStart(false);
            CoinManager.istance.addCoins((int) Timer.istance.getCurrentTime());
            coinsFine.GetComponent<Text>().text = "Coins:" + CoinManager.istance.coins.ToString();

        }
    }


}
