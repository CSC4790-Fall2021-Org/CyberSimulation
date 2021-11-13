using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class DrawCardsV2 : MonoBehaviour
{
    public bool canGetCards;

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject PlayerArea;

    public GameObject tempCard;

    public int currentCards = 0;

    public List<GameObject> cards = new List<GameObject>();

    public List<string> usedCardsNames = new List<string>();
    public List<GameObject> usedCards = new List<GameObject>();

    //public List<GameObject> childObjects = new List<GameObject>();

    GameObject originalGameObject;

    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;
    public GameObject child5;

    public RectTransform targetRect1;
    public RectTransform targetRect2;
    public RectTransform targetRect3;
    public RectTransform targetRect4;
    public RectTransform targetRect5;

    public int initialMoney;

    public int dayNum = 0;
    public Text dayText;

    public Font myNewFont;

    // Start is called before the first frame update
    void Start()
    {   
        cards.Add(Card1);
        cards.Add(Card2);
        cards.Add(Card3);
        cards.Add(Card4);
        cards.Add(Card5);
        cards.Add(Card6);
        cards.Add(Card7);
        cards.Add(Card8);
        cards.Add(Card9);
        cards.Add(Card10);

        originalGameObject = GameObject.Find("PlayerArea");

        GameObject.Find("Day Number").GetComponent<Text>().text = "1";

        dayText = GameObject.Find("Day Number").GetComponent<Text>();
        dayNum = int.Parse(GameObject.Find("Day Number").GetComponent<Text>().text);
    }

    public void NewDay()
    {
        canGetCards = true;

        dayNum++;
        dayText.text = dayNum.ToString();
        GameObject.Find("Day Number").GetComponent<Text>().text = dayText.text;
    }

    // Update is called once per frame
    public void OnClick()
    {
        /*
        GameObject c1 = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject cb1 = Instantiate(Card1Back, new Vector3(0, 0, 0), Quaternion.identity);
        c1.transform.SetParent(PlayerArea.transform, false);
        cb1.transform.SetParent(PlayerArea.transform, falsec
        cb1.transform.SetParent(c1.transform, false);
        */
                
        if(currentCards < 5 && canGetCards)
        {
            canGetCards = false;

            initialMoney = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);

            for (var i = 0; i < 5; i++)
            {
                currentCards += 1;

                tempCard = cards[Random.Range(0, cards.Count)];

                GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

                cards.Remove(tempCard);
                //can store this tempCard in an array to add it back into the pool of selectable cards at a later time
            }

            child1 = originalGameObject.transform.GetChild(0).gameObject;
            child2 = originalGameObject.transform.GetChild(1).gameObject;
            child3 = originalGameObject.transform.GetChild(2).gameObject;
            child4 = originalGameObject.transform.GetChild(3).gameObject;
            child5 = originalGameObject.transform.GetChild(4).gameObject;

            child1.gameObject.transform.localScale = new Vector3(1, 1, 1);
            child2.gameObject.transform.localScale = new Vector3(1, 1, 1);
            child3.gameObject.transform.localScale = new Vector3(1, 1, 1);
            child4.gameObject.transform.localScale = new Vector3(1, 1, 1);
            child5.gameObject.transform.localScale = new Vector3(1, 1, 1);

            /*child1.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            child2.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            child3.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            child4.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            child5.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);*/

            //DrawCard1(0.5f);
            child1.SetActive(true);
            child2.SetActive(true);
            child3.SetActive(true);
            child4.SetActive(true);
            child5.SetActive(true);

            targetRect1 = child1.GetComponent<RectTransform>();
            targetRect2 = child2.GetComponent<RectTransform>();
            targetRect3 = child3.GetComponent<RectTransform>();
            targetRect4 = child4.GetComponent<RectTransform>();
            targetRect5 = child5.GetComponent<RectTransform>();
        }
    }

/*
    public static GameObject GetChildWithName<T>(T obj, string name) where T : Component
         {
             Transform trans = obj.transform;
             Transform childTrans = trans.Find(name);
             
             if (childTrans != null)
             {
                return childTrans.gameObject;
             }
 
             return null;
         }
*/

    public void DestroyCards()
    {
        if (EventManage.Instance.nextRound() == true)
        {
            Debug.Log("Child count:" + originalGameObject.transform.childCount);

            while (originalGameObject.transform.childCount != 0)
            {
                foreach (Transform child in originalGameObject.transform)
                {
                    Debug.Log("Child count:" + originalGameObject.transform.childCount);
                    Debug.Log(child.GetComponent<CardDisplay>().nameText.text);

                    //usedCardsNames.Add(child.GetComponent<CardDisplay>().nameText.text);
                    cards.Add(child.gameObject);
                    child.SetParent(null);
                    currentCards--;
                }
            }

            usedCardsNames = new List<string>();
        }


    /*
    foreach(Transform child in originalGameObject.transform)
    {
        foreach(string str in usedCardsNames)
        {
            if(child.GetComponent<CardDisplay>().nameText.text == str)
            {
                Debug.Log("STRING EQUALS CARD 2");
            }
        }
    }


    if(currentCards == 5)
    {
        Debug.Log("within onclick of destroy cards");
        GameObject child1 = originalGameObject.transform.GetChild(0).gameObject;
        GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
        GameObject child3 = originalGameObject.transform.GetChild(2).gameObject;
        GameObject child4 = originalGameObject.transform.GetChild(3).gameObject;
        GameObject child5 = originalGameObject.transform.GetChild(4).gameObject;

        child1.SetActive(false);
        child2.SetActive(false);
        child3.SetActive(false);
        child4.SetActive(false);
        child5.SetActive(false);

        Destroy(child1);
        Destroy(child2);
        Destroy(child3);
        Destroy(child4);
        Destroy(child5);


        currentCards -= 5;
    }
    */
    }   

	public void UpdateFont()
    {
		//GameObject.Find("Chat Obj").GetComponent<Text>().font = myNewFont;
	}

    IEnumerator DrawCard1(float time)
    {
        yield return new WaitForSeconds(time);

        child1.SetActive(true);
        targetRect1 = child1.GetComponent<RectTransform>();
    }
}