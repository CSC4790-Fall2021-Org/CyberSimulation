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
    public List<GameObject> backupCards = new List<GameObject>();

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

    AudioSource cardDrawnAudio;
    AudioSource cardShuffleAudio;

    public bool repeatCard = false;

    public bool child1Active;
    public bool child2Active;
    public bool child3Active;
    public bool child4Active;
    public bool child5Active;

    public bool lastCardDrawn = true;
    public bool inChatManager = false;

    public GameObject CardDescriptionParent;
    public GameObject CardDescription;

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

        backupCards.Add(Card1);
        backupCards.Add(Card2);
        backupCards.Add(Card3);
        backupCards.Add(Card4);
        backupCards.Add(Card5);
        backupCards.Add(Card6);
        backupCards.Add(Card7);
        backupCards.Add(Card8);
        backupCards.Add(Card9);
        backupCards.Add(Card10);

        originalGameObject = GameObject.Find("PlayerArea");

        GameObject.Find("Day Number").GetComponent<Text>().text = "1";

        dayText = GameObject.Find("Day Number").GetComponent<Text>();
        dayNum = int.Parse(GameObject.Find("Day Number").GetComponent<Text>().text);

        cardDrawnAudio = GameObject.Find("Card Drawn").GetComponent<AudioSource>();
        cardShuffleAudio = GameObject.Find("ShuffleCards").GetComponent<AudioSource>();

        CardDescriptionParent = GameObject.Find("Card Descriptions");
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
            lastCardDrawn = false;

            initialMoney = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);

            Debug.Log("List Size: " + cards.Count);
            while(cards.Count < 5)
            {
                BackupAdd();
            }

            Invoke("DrawCard11", 0.5f);
            Invoke("DrawCard2", 1.0f);
            Invoke("DrawCard3", 1.5f);
            Invoke("DrawCard4", 2.0f);
            Invoke("DrawCard5", 2.5f);

            child1Active = true;
            child2Active = true;
            child3Active = true;
            child4Active = true;
            child5Active = true;

            /*for (var i = 0; i < 5; i++)
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

            //child1.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            //child2.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            //child3.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            //child4.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);
            //child5.gameObject.transform.localScale = new Vector3(0.67f, 0.67f, 0.67f);

            child1.SetActive(true);
            child2.SetActive(true);
            child3.SetActive(true);
            child4.SetActive(true);
            child5.SetActive(true);

            targetRect1 = child1.GetComponent<RectTransform>();
            targetRect2 = child2.GetComponent<RectTransform>();
            targetRect3 = child3.GetComponent<RectTransform>();
            targetRect4 = child4.GetComponent<RectTransform>();
            targetRect5 = child5.GetComponent<RectTransform>();*/
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
            Invoke("ShuffleNoise", 0.5f);

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

    /*IEnumerator DrawCard1(float time)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(time);

        currentCards += 1;

        tempCard = cards[Random.Range(0, cards.Count)];

        GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        cards.Remove(tempCard);

        child1 = originalGameObject.transform.GetChild(0).gameObject;
        child1.gameObject.transform.localScale = new Vector3(1, 1, 1);

        child1.SetActive(true);
        targetRect1 = child1.GetComponent<RectTransform>();
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }*/
    void BackupAdd()
    {
        tempCard = backupCards[Random.Range(0, backupCards.Count)];

        repeatCard = false;

        foreach(GameObject obj in cards)
        {
            if(tempCard.GetComponent<CardDisplay>().nameText.text == obj.GetComponent<CardDisplay>().nameText.text)
            {
                repeatCard = true;
            }
        }

        if(repeatCard == false)
        {
            cards.Add(tempCard);
        } 
    }

    void DrawCard11()
    {
        cardDrawnAudio.Play(0);
        currentCards += 1;

        tempCard = cards[Random.Range(0, cards.Count)];

        GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        cards.Remove(tempCard);

        child1 = originalGameObject.transform.GetChild(0).gameObject;
        child1.gameObject.transform.localScale = new Vector3(1, 1, 1);

        child1.SetActive(true);
        targetRect1 = child1.GetComponent<RectTransform>();

        child1.GetComponent<FlipCard>().CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
    }

    void DrawCard2()
    {
        cardDrawnAudio.Play(0);
        currentCards += 1;

        tempCard = cards[Random.Range(0, cards.Count)];

        GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        cards.Remove(tempCard);

        child2 = originalGameObject.transform.GetChild(1).gameObject;
        child2.gameObject.transform.localScale = new Vector3(1, 1, 1);

        child2.SetActive(true);
        targetRect2 = child2.GetComponent<RectTransform>();

        child2.GetComponent<FlipCard>().CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
    }

    void DrawCard3()
    {
        cardDrawnAudio.Play(0);
        currentCards += 1;

        tempCard = cards[Random.Range(0, cards.Count)];

        GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        cards.Remove(tempCard);

        child3 = originalGameObject.transform.GetChild(2).gameObject;
        child3.gameObject.transform.localScale = new Vector3(1, 1, 1);

        child3.SetActive(true);
        targetRect3 = child3.GetComponent<RectTransform>();

        child3.GetComponent<FlipCard>().CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
    }

    void DrawCard4()
    {
        cardDrawnAudio.Play(0);
        currentCards += 1;

        tempCard = cards[Random.Range(0, cards.Count)];

        GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        cards.Remove(tempCard);

        child4 = originalGameObject.transform.GetChild(3).gameObject;
        child4.gameObject.transform.localScale = new Vector3(1, 1, 1);

        child4.SetActive(true);
        targetRect4 = child4.GetComponent<RectTransform>();

        child4.GetComponent<FlipCard>().CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
    }

    void DrawCard5()
    {
        cardDrawnAudio.Play(0);
        currentCards += 1;

        tempCard = cards[Random.Range(0, cards.Count)];

        GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(PlayerArea.transform, false);

        cards.Remove(tempCard);

        child5 = originalGameObject.transform.GetChild(4).gameObject;
        child5.gameObject.transform.localScale = new Vector3(1, 1, 1);

        child5.SetActive(true);
        targetRect5 = child5.GetComponent<RectTransform>();
        lastCardDrawn = true;

        child5.GetComponent<FlipCard>().CardDescription = CardDescriptionParent.transform.Find("Card Window").gameObject;
    }

    public void CardsActive()
    {
        inChatManager = false;

        if(GameObject.Find("PlayerArea").transform.childCount > 0)
        {
            if(child1Active == true)
            {
                child1.SetActive(true);
            }
            if(child2Active == true)
            {
                child2.SetActive(true);
            }
            if(child3Active == true)
            {
                child3.SetActive(true);
            }
            if(child4Active == true)
            {
                child4.SetActive(true);
            }
            if(child5Active == true)
            {
                child5.SetActive(true);
            }
            /*
            child1.SetActive(true);
            child2.SetActive(true);
            child3.SetActive(true);
            child4.SetActive(true);
            child5.SetActive(true); */
        }
    }

    public void CardsNotActive()
    {
        inChatManager = true;

        if(lastCardDrawn == true)
        {
            if(GameObject.Find("PlayerArea").transform.childCount > 0)
            {
                if(child1Active == true)
                {
                    child1.SetActive(false);
                }
                if(child2Active == true)
                {
                    child2.SetActive(false);
                }
                if(child3Active == true)
                {
                    child3.SetActive(false);
                }
                if(child4Active == true)
                {
                    child4.SetActive(false);
                }
                if(child5Active == true)
                {
                    child5.SetActive(false);
                }
                /*
                child1.SetActive(false);
                child2.SetActive(false);
                child3.SetActive(false);
                child4.SetActive(false);
                child5.SetActive(false); */
            }
        }
    }

    public void ShuffleNoise()
    {
        cardShuffleAudio.Play(0);
    }

}