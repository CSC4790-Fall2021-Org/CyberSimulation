using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCardsV2 : MonoBehaviour
{
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

    int currentCards = 0;

    List<GameObject> cards = new List<GameObject>();

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
    }

    // Update is called once per frame
    public void OnClick()
    {
        /*
        GameObject c1 = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
        GameObject cb1 = Instantiate(Card1Back, new Vector3(0, 0, 0), Quaternion.identity);
        c1.transform.SetParent(PlayerArea.transform, false);
        cb1.transform.SetParent(PlayerArea.transform, false);
        cb1.transform.SetParent(c1.transform, false);
        */
                
        if(currentCards < 5)
        {
            for (var i = 0; i < 5; i++)
            {
                currentCards += 1;

                tempCard = cards[Random.Range(0, cards.Count)];

                GameObject playerCard = Instantiate(tempCard, new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(PlayerArea.transform, false);

                cards.Remove(tempCard);
                //can store this tempCard in an array to add it back into the pool of selectable cards at a later time
            }
        }
    }

    public void DestroyCards()
    {
        if(currentCards == 5)
        {
            Debug.Log("within onclick of destroy cards");
            GameObject originalGameObject = GameObject.Find("PlayerArea");
            GameObject child1 = originalGameObject.transform.GetChild(0).gameObject;
            GameObject child2 = originalGameObject.transform.GetChild(1).gameObject;
            GameObject child3 = originalGameObject.transform.GetChild(2).gameObject;
            GameObject child4 = originalGameObject.transform.GetChild(3).gameObject;
            GameObject child5 = originalGameObject.transform.GetChild(4).gameObject;

            Destroy(child1);
            Destroy(child2);
            Destroy(child3);
            Destroy(child4);
            Destroy(child5);

            currentCards -= 5;
        }
    }
}