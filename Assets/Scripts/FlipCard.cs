//inspiration from Cezary_Sharp

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class FlipCard : MonoBehaviour
{
    public float x,y,z;

    public GameObject cardBack;
    public Text description;
    public Text name;
    public Image image;
    public bool cardBackIsActive;
   
    public string text;
    public int timer;
    public Canvas canvas;
    public string nameCard;
    public Canvas temp;
    public bool a = false;
    public List<string> ddrawc;
    public List<string> ID;

    public GameObject CardDescriptionParent;
    public GameObject CardDescription;
    public GameObject Description;
    public GameObject Name;
    public GameObject Imagee;
    public GameObject drawCardsButton;
    public GameObject windowMoney;
    public string windowMoneyText;

    // Start is called before the first frame update
    void Start()
    {
        cardBackIsActive = false;
        drawCardsButton = GameObject.Find("Draw Cards Button");
        CardDescriptionParent = GameObject.Find("Card Descriptions");
        CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
        Description = CardDescription.transform.Find("desc").gameObject;
        Name = CardDescription.transform.Find("name").gameObject;
        windowMoney = CardDescription.transform.Find("WindowMoney").gameObject;
        windowMoneyText = windowMoney.GetComponent<Text>().text;
        description = Description.GetComponent<Text>();
        Imagee = CardDescription.transform.Find("CardImage").gameObject;
        image = Imagee.GetComponent<Image>();
        name = Name.GetComponent<Text>();
        ddrawc = new List<string>(10);
        ID = new List<string>(10);
        for (int i = 0; i < GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription.Length; i++)
        {
            //Debug.Log("sssss2e213 " + i);
            ddrawc.Add(GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription[i]);
            //Debug.Log("sssss2e213 " + ddrawc[i]);
            ID.Add(GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardName[i]);
        }


    }
    public void popup(Canvas canvas)
    {
        if (a == false)
        {
            a = true;
            canvas.enabled = true;

        }
        else if (a == true)
        {
            a = false;
            canvas.enabled = false;
        }
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

        if(drawCardsButton.GetComponent<DrawCardsV2>().lastCardDrawn == true && drawCardsButton.GetComponent<DrawCardsV2>().inChatManager == false)
        {

            if(Input.GetMouseButtonDown(1))
            {
                //StartFlip();
                //  string temp = GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription[];
                //GameObject.Find("Draw Cards Button").GetComponent<DrawCardsV2>().targetRect1;
                //Alan's Code Here
                /* 
                ddrawc = GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription;
                string tempp =  GameObject.Find("System").GetComponent<CSVScript>().endRoundSum[1];
                description.text = tempp;
                temp = Instantiate(canvas, new Vector3(0, 0, 0), Quaternion.identity);
                popup(temp);
                Debug.Log("in flip + temp " + tempp);
                */

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
                
                if (RectTransformUtility.RectangleContainsScreenPoint(targetRect1, mousePos))
                {
                    CardDescription.transform.Find("WindowMoney").GetComponent<Text>().text = child1.GetComponent<CardDisplay>().moneyValue.text;

                    CardDescription.transform.Find("CardImage").GetComponent<Image>().sprite = child1.transform.GetChild(0).GetComponent<Image>().sprite;

                    string temp = "";
                
                    nameCard = child1.GetComponent<CardDisplay>().nameText.text;
                    Debug.Log("namecard" + nameCard);

                    int d = ID.IndexOf(nameCard);
                //  image = child1.GetComponent<Image>();
                    Debug.Log("d" + d);
                description.text = ddrawc[d];
                    name.text = ID[d];
                    CardDescription.SetActive(true);
                    drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
                }

                if (RectTransformUtility.RectangleContainsScreenPoint(targetRect2, mousePos))
                {
                    CardDescription.transform.Find("WindowMoney").GetComponent<Text>().text = child2.GetComponent<CardDisplay>().moneyValue.text;

                    CardDescription.transform.Find("CardImage").GetComponent<Image>().sprite = child2.transform.GetChild(0).GetComponent<Image>().sprite;

                    nameCard = child2.GetComponent<CardDisplay>().nameText.text;
                    Debug.Log("namecard" + nameCard);
                    int d = ID.IndexOf(nameCard);
                    Debug.Log("d" + d);
                    name.text = ID[d];
                    description.text = ddrawc[d];
                    CardDescription.SetActive(true);
                    drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
                }

                if (RectTransformUtility.RectangleContainsScreenPoint(targetRect3, mousePos))
                {
                    CardDescription.transform.Find("WindowMoney").GetComponent<Text>().text = child3.GetComponent<CardDisplay>().moneyValue.text;

                    CardDescription.transform.Find("CardImage").GetComponent<Image>().sprite = child3.transform.GetChild(0).GetComponent<Image>().sprite;

                    nameCard = child3.GetComponent<CardDisplay>().nameText.text;
                    Debug.Log("namecard" + nameCard);
                    int d = ID.IndexOf(nameCard);
                    Debug.Log("d" + d);
                    name.text = ID[d];
                    description.text = ddrawc[d];
                    CardDescription.SetActive(true);
                    drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
                }

                if (RectTransformUtility.RectangleContainsScreenPoint(targetRect4, mousePos))
                {
                    CardDescription.transform.Find("WindowMoney").GetComponent<Text>().text = child4.GetComponent<CardDisplay>().moneyValue.text;

                    CardDescription.transform.Find("CardImage").GetComponent<Image>().sprite = child4.transform.GetChild(0).GetComponent<Image>().sprite;

                    nameCard = child4.GetComponent<CardDisplay>().nameText.text;
                    Debug.Log("namecard" + nameCard);
                    int d = ID.IndexOf(nameCard);
                    Debug.Log("d" + d);
                    name.text = ID[d];
                    description.text = ddrawc[d];
                    CardDescription.SetActive(true);
                    drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
                }

                if (RectTransformUtility.RectangleContainsScreenPoint(targetRect5, mousePos))
                {
                    CardDescription.transform.Find("WindowMoney").GetComponent<Text>().text = child5.GetComponent<CardDisplay>().moneyValue.text;

                    CardDescription.transform.Find("CardImage").GetComponent<Image>().sprite = child5.transform.GetChild(0).GetComponent<Image>().sprite;

                    nameCard = child5.GetComponent<CardDisplay>().nameText.text;
                    Debug.Log("namecard" + nameCard);
                    int d = ID.IndexOf(nameCard);
                    Debug.Log("d" + d);
                    name.text = ID[d];
                    description.text = ddrawc[d];
                    CardDescription.SetActive(true);
                    drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
                }


            }
        }
    }
    public void closee(Canvas canvas)
    {

    }
    public void StartFlip()
    {
        StartCoroutine(CalculateFlip());
    }

    public void Flip()
    {
        if(cardBackIsActive == true)
        {
            cardBack.SetActive(false);
            cardBackIsActive = false;
        }
        else
        {
            cardBack.SetActive(true);
            cardBackIsActive = true;
        }
    }

    IEnumerator CalculateFlip()
    {
        for(int i = 0; i < 180; i++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Rotate (new Vector3(x, y, z));
            timer ++;

            if(timer == 90 || timer == -90)
            {
                Flip();
            }
        }

        timer = 0;
    }
}
