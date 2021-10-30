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
        //Debug.Log("Money value: " + money);
        moneyText = GameObject.Find("Money").GetComponent<Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Input.mousePosition;
            {
                //Debug.Log("X: " + mousePos.x);
                //Debug.Log("Y: " + mousePos.y);
                //Debug.Log(mousePos.ToString());
            }

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

            GameObject originalGameObject = GameObject.Find("PlayerArea");
            GameObject child1 = originalGameObject.transform.GetChild(0).gameObject;
            GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
            GameObject child3 = originalGameObject.transform.GetChild(2).gameObject;
            GameObject child4 = originalGameObject.transform.GetChild(3).gameObject;
            GameObject child5 = originalGameObject.transform.GetChild(4).gameObject;

            RectTransform targetRect1 = child1.GetComponent<RectTransform>();
            RectTransform targetRect2 = child2.GetComponent<RectTransform>();
            RectTransform targetRect3 = child3.GetComponent<RectTransform>();
            RectTransform targetRect4 = child4.GetComponent<RectTransform>();
            RectTransform targetRect5 = child5.GetComponent<RectTransform>();

            //card 1
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect1, mousePos))
            {
                Debug.Log("inside card 1");
                cardMoney = int.Parse(child1.GetComponent<CardDisplay>().moneyValue.text);

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }
 
             //card 2
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect2, mousePos))
            {
                Debug.Log("inside card 2");
                cardMoney = int.Parse(child2.GetComponent<CardDisplay>().moneyValue.text);

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }

            //card 3
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect3, mousePos))
            {
                Debug.Log("inside card 3");
                cardMoney = int.Parse(child3.GetComponent<CardDisplay>().moneyValue.text);

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }

            //card 4
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect4, mousePos))
            {
                Debug.Log("inside card 4");
                cardMoney = int.Parse(child4.GetComponent<CardDisplay>().moneyValue.text);

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }

            //card 5
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect5, mousePos))
            {
                Debug.Log("inside card 5");
                cardMoney = int.Parse(child5.GetComponent<CardDisplay>().moneyValue.text);

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }
            
            //cardMoney = int.Parse(GameObject.Find("Money Value").GetComponent<Text>().text);
            //cardMoney = int.Parse(child.GetComponent<CardDisplay>().moneyValue.text);
            //Debug.Log("moneyText: " + moneyText);
        }
    }
}
