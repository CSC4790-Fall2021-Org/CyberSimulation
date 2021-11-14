using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class OpenSystemMenuV2 : MonoBehaviour
{
    public static OpenSystemMenuV2 Instance { get; set; }
    // Start is called before the first frame update
    public Canvas canvas;
    public bool a = false;
    public bool b = false;
    public bool ended = false;
    public string final;
    public int diff;
    public int threatmoney;
 
    public List<int> thirtt;
    public List<int> sixtysix;
    public List<int> ninety;

    public int money;
    public Text moneyText1;
    public int dollars;
    List<string> drawc;
    public List<string> ddrawc;
    public string[] intdrawc;
    public int initialDollars;
    public string[] cardint;
    public int cardcounter;
    public int cardindex;
    public string[] cc;
    public GameObject drawCardsButton;

    void Start()
    {
        drawCardsButton = GameObject.Find("Draw Cards Button");
    }

    public void popup()
    {
        a = GameObject.Find("popupEndRound").GetComponent<OpenSystemMenu>().a;

        if (a == true&&EventManage.Instance.nextRound()==true)
        {
            money = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);
            moneyText1 = GameObject.Find("Money").GetComponent<Text>();
            dollars = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);
           
             drawc = drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames;
            ddrawc = new List<string>(10);
        
            for (int i = 0; i < GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription.Length; i++)
            {
                //Debug.Log("sssss2e213 " + i);
                ddrawc.Add (GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription[i]);
                //Debug.Log("sssss2e213 " + ddrawc[i]);

            }
        
            intdrawc= GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardName;


            //   drawc[1] = ", " + drawc[1];
            initialDollars = drawCardsButton.GetComponent<DrawCardsV2>().initialMoney;

            a = true;
            ended = true;
            canvas.enabled = true;
            threatmoney = GameObject.Find("System").GetComponent<CSVScript>().threatmoney[EventManage.Instance.getcurrScenario()];
            string temp = GameObject.Find("System").GetComponent<CSVScript>().thirtythree[EventManage.Instance.getcurrScenario()];
            string[] values = temp.Split(",".ToCharArray());

           thirtt = new List<int>();

            for(int i = 0; i < values.Length; i++)
            {
                thirtt.Add(int.Parse(values[i]));
                Debug.Log("ss " + values[i]);
            }

            temp = GameObject.Find("System").GetComponent<CSVScript>().sixtysix[EventManage.Instance.getcurrScenario()];
            values = temp.Split(",".ToCharArray());

             sixtysix = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                sixtysix.Add(int.Parse(values[i]));
                Debug.Log("ss " + values[i]);
            }

            temp = GameObject.Find("System").GetComponent<CSVScript>().ninety[EventManage.Instance.getcurrScenario()];
             values = temp.Split(",".ToCharArray());

           ninety = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                ninety.Add( int.Parse(values[i]));
                Debug.Log("ss " + values[i]);
            }
           

            
            for(int i = 0; i < drawc.Count; i++)
            {
          // if()
            }
            cardcounter = 0;
            cc = new string[10];
            cardindex = 0;
            for (int i = 0; i < intdrawc.Length; i++)
            {
                if ((drawc.FindIndex(a => a.Contains(intdrawc[i])) != -1)){
                    cardindex = drawc.FindIndex(a => a.Contains(intdrawc[i]));
                    cc[cardcounter] = intdrawc[i];
                    Debug.Log("cardcount " + cardindex);
                    cardcounter++;
                }
     
            }
           
            for (int i = 0; i < drawc.Count; i++)
            {
                if (i <= drawc.Count - 1)
                {
                    drawc[i] = drawc[i] + ", ";
                    Debug.Log("used cards " + drawc[i]);
                }
            }
            final = "You selected the following cards:";
            for (int i = 0; i < drawc.Count; i++)
            {
                final = final + drawc[i];
            }
            Debug.Log("fina l is " + final);
            diff = dollars - initialDollars;
            EventManage.Instance.incrementScenario();


        }
      
    }
    public void popdown()
    {
  
        ended = false;
        GameObject.Find("ChatManager").GetComponent<ChatManager>().checkChoice = false;
        GameObject.Find("ChatManager").GetComponent<ChatManager>().initial = false;

        GameObject.Find("ChatManager").GetComponent<ChatManager>().correctChoice = "";
        GameObject.Find("ChatManager").GetComponent<ChatManager>().choicecorrect = false;
    }
    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
