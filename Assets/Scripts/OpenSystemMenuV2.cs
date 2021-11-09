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
 
    public int[] thirtt;
    public int[] sixtysix;
    public int[] ninety;

    public int money;
    public Text moneyText1;
    public int dollars;
    public int initialDollars;
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
           
            List<String> drawc = drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames;
           

            for(int i = 0; i < drawc.Count; i++)
            {
                if (i==0 || i >= drawc.Count - 1)
                {
                    drawc[i] = "," + drawc[i] + " ,";
                }
            }
            initialDollars = drawCardsButton.GetComponent<DrawCardsV2>().initialMoney;

            a = true;
            ended = true;
            canvas.enabled = true;
            threatmoney = GameObject.Find("System").GetComponent<CSVScript>().threatmoney[EventManage.Instance.getcurrScenario()];
            string temp = GameObject.Find("System").GetComponent<CSVScript>().thirtythree[EventManage.Instance.getcurrScenario()];
            string[] values = temp.Split(",".ToCharArray());

            int[] thirtt = new int[values.Length];

            for(int i = 0; i < values.Length; i++)
            {
                thirtt[i] = int.Parse(values[i]);
                Debug.Log("ss " + values[i]);
            }

            temp = GameObject.Find("System").GetComponent<CSVScript>().sixtysix[EventManage.Instance.getcurrScenario()];
            values = temp.Split(",".ToCharArray());

            int[] sixtysix = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                sixtysix[i] = int.Parse(values[i]);
                Debug.Log("ss " + values[i]);
            }

            temp = GameObject.Find("System").GetComponent<CSVScript>().ninety[EventManage.Instance.getcurrScenario()];
             values = temp.Split(",".ToCharArray());

            int[] ninety = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                ninety[i] = int.Parse(values[i]);
                Debug.Log("ss " + values[i]);
            }
           

            final = "You selected the following cards:";
            for (int i = 0; i < drawc.Count; i++)
            {
                final = final + drawc[i];
            }
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
