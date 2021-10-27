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

    public Text moneyText;
    
    // Start is called before the first frame update
    void Start()
    {
        money = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);
        Debug.Log("Money value: " + money);
        moneyText = GameObject.Find("Money").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            money = money - 10;

            //Debug.Log("moneyText: " + moneyText);
            
            moneyText.text = money.ToString();

            GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
        }
    }
}
