using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreTable :Ranking
{
    // Start is called before the first frame update
    private Transform entryContainer;
    private Transform entryTemplate;
    void Start()
    {
        entryContainer = GameObject.Find("HighScoreEntryContainer").transform;
        entryTemplate = entryContainer.Find("HighScoreEntryTemplate");

        entryTemplate.gameObject.SetActive(false);
        Debug.Log(getCount());

        for (int i = 0; i < getCount() && i<10; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTrasform = entryTransform.GetComponent<RectTransform>();
            entryRectTrasform.anchoredPosition = new Vector2(0, -40f * i);
            entryTransform.gameObject.SetActive(true);

            int r = i +1;
            string rankString;
            switch (r)
            {
                default: rankString = r + " TH"; break;

                case 1: rankString = "1 ST"; break;
                case 2: rankString = "2 ND"; break;
                case 3: rankString = "3 RD"; break;
            }

            entryTransform.Find("posText").GetComponent<Text>().text = rankString;

            entryTransform.Find("scoreText").GetComponent<Text>().text = getHighScore()[i].getVal().ToString();

            entryTransform.Find("nameText").GetComponent<Text>().text = getHighScore()[i].getNome();

        }
    }
}
