//inspiration from Cezary_Sharp

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FlipCard : MonoBehaviour
{
    public float x,y,z;

    public GameObject cardBack;
    public TextMeshProUGUI description;
    public bool cardBackIsActive;
    public string[] ddrawc;
    public int timer;
    public Canvas canvas;
    public Canvas temp;
    public bool a = false;

    public GameObject CardDescriptionParent;
    public GameObject CardDescription;

    public GameObject drawCardsButton;

    // Start is called before the first frame update
    void Start()
    {
        cardBackIsActive = false;
        drawCardsButton = GameObject.Find("Draw Cards Button");
        CardDescriptionParent = GameObject.Find("Card Descriptions");
        CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
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
                CardDescription.SetActive(true);
                drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
            }

            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect2, mousePos))
            {
                CardDescription.SetActive(true);
                drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
            }

            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect3, mousePos))
            {
                CardDescription.SetActive(true);
                drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
            }

            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect4, mousePos))
            {
                CardDescription.SetActive(true);
                drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
            }

            if (RectTransformUtility.RectangleContainsScreenPoint(targetRect5, mousePos))
            {
                CardDescription.SetActive(true);
                drawCardsButton.GetComponent<DrawCardsV2>().inChatManager = true;
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
