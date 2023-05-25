using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    GameObject timeGauge;
    GameObject distanceText;
    int distance = 0;

    void Start()
    {
        this.distanceText = GameObject.Find("ki");
        this.timeGauge = GameObject.Find("timeGauge");
    }

    public void DecreaseTime()
    {
        this.timeGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }

    private void Update()
    {
        this.distance += 1;
        this.distanceText.GetComponent<TextMeshProUGUI>().text =
            this.distance.ToString("D7") + "km";

        this.timeGauge.GetComponent<Image>().fillAmount -= 0.00016667f;

        if (this.timeGauge.GetComponent<Image>().fillAmount <=0)
        {
            SceneManager.LoadScene("Title Scene");
        }
    }
}
