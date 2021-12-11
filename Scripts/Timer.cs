using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer istance;
    float currentTime = 0f;
    float startingTime = 40f;
    [SerializeField] Text obj;
    GameObject car;
   [SerializeField] GameObject canvas;
    [SerializeField] GameObject coin;
    private bool start;
    void Start()
    {
        istance = this;
        currentTime = startingTime;
        start = false;
        car = GameObject.Find("car");
        canvas.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (start == true && Mathf.Ceil(currentTime) > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            obj.color = Color.Lerp(Color.red, Color.black, currentTime);
            obj.text = Mathf.Ceil(currentTime).ToString();
        }

        if (Mathf.Ceil(currentTime) == 0 && start)
        {
            start = false;
            car.GetComponent<CarDriver>().setCheck();
            gameObject.GetComponent<AudioSource>().Play();
            canvas.SetActive(true);
            if (CoinManager.istance.coins >= 100) CoinManager.istance.coins -= 100;
            else CoinManager.istance.coins = 0;
            CoinManager.istance.saveCoins();
            coin.SetActive(false);
        }

        if (Mathf.Ceil(CarDamage.instance.getHealt()) <= 0)
        {
            car.GetComponent<CarDriver>().setCheck();
            gameObject.GetComponent<AudioSource>().Play();
            canvas.SetActive(true);
            if (CoinManager.istance.coins >= 100) CoinManager.istance.coins -= 100;
            else CoinManager.istance.coins = 0;
            CoinManager.istance.saveCoins();
            coin.SetActive(false);
        }

    }

    public void AddTime(float tempo)
    {
        currentTime += tempo;
    }

    public void setStart(bool b)
    {
        start = b;
    }

    public float getCurrentTime() { return Mathf.Ceil(currentTime); }
}

    
