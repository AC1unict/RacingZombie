using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour
{
    public class nodo
    {
        //public static nodo instance;
        private string nome;
        private int val;

        public nodo(string nome,int val)
        {
            //instance = this;
            this.nome = nome;
            this.val = val;
        }

        public void setVal(int v) { val = v; }
        public int getVal() { return val; }
        public void setNome(string n) { nome = n; }
        public string getNome() { return nome; }
    }

    string spazio = "             ";
    public static Ranking instance;
    List<nodo> rank;
    int count;
    //[SerializeField] GameObject gui;

    private void Awake()
    {
        rank = new List<nodo>();
        instance = this;
        count = PlayerPrefs.GetInt("count");
        getRanking();
        sortList();
       //foreach (nodo i in rank) Debug.Log("Nome: " + i.getNome() + spazio + i.getVal() + '\r');
    }


    public void saveRank()
    {
       string j="";
        string k = "val ";
        int count = 0;
        foreach (nodo i in rank)
        {
            PlayerPrefs.SetString(j += 'a', i.getNome());
            PlayerPrefs.SetInt(k+='a', i.getVal());
            Debug.Log(j+spazio+k);
            count++;
        }

        PlayerPrefs.SetInt("count", count);
       // Debug.Log("count: " + count);
    }

    public List<nodo> getRank()
    {
       
        List<nodo> temp = new List<nodo>();
        if (count == 0) return temp;

        else 
        {
            
            string j = "";
            string k = "val ";
            for (int i = 0; i <count; i++)
            {
                nodo n = new nodo(PlayerPrefs.GetString(j += 'a'), PlayerPrefs.GetInt(k += 'a'));
                temp.Add(n);
            }
        }
       
        return temp;
    }

    public void addRank(nodo n)
    {
        rank.Add(n);
    }

    public void addRank(string n,int val)
    {
        nodo nuovo = new nodo(n, val);
        addRank(nuovo);
    }

    public void getRanking()
    {

        if (getRank().Count != 0) {
           // Debug.Log("eccomi");
            rank = getRank();
        }
            
    }

    public int getCount() { return count; }

    public List<nodo> getHighScore() { return rank;}

    public void sortList()
    {
        for(int i = 0; i < count-1; i++)
        {
            for(int j = i + 1; j < count; j++)
            {
                if (rank[i].getVal() < rank[j].getVal())
                {
                    nodo temp;
                    temp = rank[i];
                    rank[i] = rank[j];
                    rank[j] = temp;
                }
            }
        }
    }


}
