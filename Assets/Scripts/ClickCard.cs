using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class ClickCard : MonoBehaviour
{
    public int money;
    public Text moneyText;

    public int cardMoney;
    
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
            /*
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
         
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("this is the object" + hit.transform.gameObject.name);
            }
            */

            cardMoney = int.Parse(GameObject.Find("Money Value").GetComponent<Text>().text);
            money = money - cardMoney;

            //Debug.Log("moneyText: " + moneyText);
            
            moneyText.text = money.ToString();

            GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
        }
    }
}
