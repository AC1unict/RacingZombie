using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReloadGame : MonoBehaviour
{
    public static ReloadGame instance;
    private int scene;

    private void Start()
    {
        instance = this;
    }

    /*void Update()
    {
        loadScene();
    }*/

    public void loadScene()
    {
        InsertCoin.instance.setCoins();
        SceneManager.LoadScene(scene);
    }

    public void setScene(int n) { scene = n; }

    public void destroy() { PlayerPrefs.DeleteAll(); }

    public void Quit()
    {
        Application.Quit(0);
    }

}
