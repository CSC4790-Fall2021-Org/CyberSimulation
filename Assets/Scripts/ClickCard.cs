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
            GameObject drawCardsButton = GameObject.Find("Draw Cards Button");

            GameObject originalGameObject = GameObject.Find("PlayerArea");
            GameObject child1 = drawCardsButton.GetComponent<DrawCardsV2>().child1;
            GameObject child2 = drawCardsButton.GetComponent<DrawCardsV2>().child2;
            GameObject child3 = drawCardsButton.GetComponent<DrawCardsV2>().child3;
            GameObject child4 = drawCardsButton.GetComponent<DrawCardsV2>().child4;
            GameObject child5 = drawCardsButton.GetComponent<DrawCardsV2>().child5;

            RectTransform targetRect1 = drawCardsButton.GetComponent<DrawCardsV2>().targetRect1;
            RectTransform targetRect2 = drawCardsButton.GetComponent<DrawCardsV2>().targetRect2;
            RectTransform targetRect3 = drawCardsButton.GetComponent<DrawCardsV2>().targetRect3;
            RectTransform targetRect4 = drawCardsButton.GetComponent<DrawCardsV2>().targetRect4;
            RectTransform targetRect5 = drawCardsButton.GetComponent<DrawCardsV2>().targetRect5;

            //card 1
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect1, mousePos))
            {
                //Debug.Log("inside card 1");
                cardMoney = int.Parse(child1.GetComponent<CardDisplay>().moneyValue.text);
                if (!drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Contains(child1.GetComponent<CardDisplay>().nameText.text))
                {
                    drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Add(child1.GetComponent<CardDisplay>().nameText.text);
                }
                
                //drawCardsButton.GetComponent<DrawCardsV2>().usedCards.Add(child1);
                Destroy(child1);
                child1.transform.SetParent(null);  

                drawCardsButton.GetComponent<DrawCardsV2>().currentCards = originalGameObject.transform.childCount;

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }
 
            //card 2
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect2, mousePos))
            {
                //Debug.Log("inside card 2");
                cardMoney = int.Parse(child2.GetComponent<CardDisplay>().moneyValue.text);
                if (!drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Contains(child2.GetComponent<CardDisplay>().nameText.text))
                {
                    drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Add(child2.GetComponent<CardDisplay>().nameText.text);
                }
                Destroy(child2);
                child2.transform.SetParent(null);  

                drawCardsButton.GetComponent<DrawCardsV2>().currentCards = originalGameObject.transform.childCount;

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }

            //card 3
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect3, mousePos))
            {
                //Debug.Log("inside card 3");
                cardMoney = int.Parse(child3.GetComponent<CardDisplay>().moneyValue.text);
                if (!drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Contains(child3.GetComponent<CardDisplay>().nameText.text))
                {
                    drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Add(child3.GetComponent<CardDisplay>().nameText.text);
                }
                Destroy(child3);
                child3.transform.SetParent(null);  

                drawCardsButton.GetComponent<DrawCardsV2>().currentCards = originalGameObject.transform.childCount;

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }

            //card 4
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect4, mousePos))
            {
                //Debug.Log("inside card 4");
                cardMoney = int.Parse(child4.GetComponent<CardDisplay>().moneyValue.text);
                if (!drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Contains(child4.GetComponent<CardDisplay>().nameText.text))
                {
                    drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Add(child4.GetComponent<CardDisplay>().nameText.text);
                }
                Destroy(child4);
                child4.transform.SetParent(null);  

                drawCardsButton.GetComponent<DrawCardsV2>().currentCards = originalGameObject.transform.childCount;

                money = money - cardMoney;
                moneyText.text = money.ToString();
                GameObject.Find("Money").GetComponent<Text>().text = moneyText.text;
            }

            //card 5
            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect5, mousePos))
            {
                //Debug.Log("inside card 5");
                cardMoney = int.Parse(child5.GetComponent<CardDisplay>().moneyValue.text);
                if (!drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Contains(child5.GetComponent<CardDisplay>().nameText.text))
                {
                    drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames.Add(child5.GetComponent<CardDisplay>().nameText.text);
                }
                Destroy(child5);
                child5.transform.SetParent(null);  

                drawCardsButton.GetComponent<DrawCardsV2>().currentCards = originalGameObject.transform.childCount;

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
