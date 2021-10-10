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
        GameObject.Find("Money").GetComponent<Text>();
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
