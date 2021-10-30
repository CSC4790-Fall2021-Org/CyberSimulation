using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class MoneyDisplay : MonoBehaviour
{
    public Text money;
    public string temp;  

    void Start () {
        //this.SetMoney("100000");

        GameObject.Find("Money").GetComponent<Text>().text = "100";
        //dollars = GameObject.Find("Money Int").GetComponent<int>();

        dollars = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);
        //Print();
 
        //GameObject.Find("Money Int").GetComponent<int>() = 100;


        //money.Text = GameObject.Find("Money").GetComponent<Text>();
    }

    public string GetMoney (MoneyDisplay money)
    {
        return money.temp;
    }

    public void SetMoney (string money)
    {
        this.temp = money;
    }
}
