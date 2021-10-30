using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class ClickCard : MonoBehaviour
{
    public int money;
    String temp;
    //public String strMoney = money.toString();
    //public int intMoney = int.Parse(strMoney);
    
    // Start is called before the first frame update
    void Start()
    {
        money = 100;
        //temp = GameObject.Find("Money").GetComponent<Text>().text;
        //Int32.TryParse(temp, out money);
        // String f =GameObject.Find("MoneyText").GetComponent<MoneyDisplay>().temp();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //money.text = (intMoney - 10).toString();
            money = money - 10;
        }
    }
}
