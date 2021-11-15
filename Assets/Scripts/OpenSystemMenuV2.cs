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
    public double threatmoney;
    bool thirty;
    bool sixty;
    bool nine;
    public List<int> thirtt;
    public List<int> sixtysix;
    public List<int> ninety;

    public int money;
    public Text moneyText1;
    public int dollars;
    List<string> drawc;
    public List<string> ddrawc;
    public List<string> intdrawc;
    public int initialDollars;
    public string[] cardint;
    public int cardcounter;
    public int cardindex;
    public int[] cc;
    public GameObject drawCardsButton;

    void Start()
    {
        drawCardsButton = GameObject.Find("Draw Cards Button");
    }

    public void popup()
    {
        a = GameObject.Find("popupEndRound").GetComponent<OpenSystemMenu>().a;

        if (a == true && EventManage.Instance.nextRound() == true)
        {
            money = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);
            moneyText1 = GameObject.Find("Money").GetComponent<Text>();
            dollars = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);

            drawc = drawCardsButton.GetComponent<DrawCardsV2>().usedCardsNames;
            ddrawc = new List<string>(10);

            for (int i = 0; i < GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription.Length; i++)
            {
                //Debug.Log("sssss2e213 " + i);
                ddrawc.Add(GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardDescription[i]);
                //Debug.Log("sssss2e213 " + ddrawc[i]);

            }

            string[] tempvar2 = GameObject.Find("Ex").GetComponent<CSVScriptCard>().cardName;

            for (int i = 0; i < tempvar2.Length; i++)
            {
                intdrawc.Add(tempvar2[i]);
            }

            //   drawc[1] = ", " + drawc[1];
            initialDollars = drawCardsButton.GetComponent<DrawCardsV2>().initialMoney;

            a = true;
            ended = true;
            canvas.enabled = true;
            threatmoney = GameObject.Find("System").GetComponent<CSVScript>().threatmoney[EventManage.Instance.getcurrScenario()];
            string temp = GameObject.Find("System").GetComponent<CSVScript>().thirtythree[EventManage.Instance.getcurrScenario()];

            string[] values = temp.Split(",".ToCharArray());

            thirtt = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                thirtt.Add(int.Parse(values[i]));
                Debug.Log("ss1 " + values[i]);
            }

            temp = GameObject.Find("System").GetComponent<CSVScript>().sixtysix[EventManage.Instance.getcurrScenario()];
            values = temp.Split(",".ToCharArray());

            sixtysix = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                sixtysix.Add(int.Parse(values[i]));
                Debug.Log("ss2 " + values[i]);
            }

            temp = GameObject.Find("System").GetComponent<CSVScript>().ninety[EventManage.Instance.getcurrScenario()];
            values = temp.Split(",".ToCharArray());

            ninety = new List<int>();

            for (int i = 0; i < values.Length; i++)
            {
                ninety.Add(int.Parse(values[i]));
                Debug.Log("ss3 " + values[i]);
            }



            for (int i = 0; i < drawc.Count; i++)
            {
                // if()
            }
            cardcounter = 0;
            cc = new int[10];
            cardindex = 0;
            for (int i = 0; i < drawc.Count; i++)
            {
                if ((Array.IndexOf(tempvar2, drawc[i]) != -1))
                {
                    cardindex = Array.IndexOf(tempvar2, drawc[i]);
                    cc[cardcounter] = cardindex+1;
                    Debug.Log("cardcount " + cardindex);
                    Debug.Log("cc " + cc[cardcounter]);
                    cardcounter++;
                }

            }
            Debug.Log("got here!");
            for (int i = 0; i < cc.Length; i++)
            {
                if (thirtt.Contains(cc[i]))
                {
                    Debug.Log("bool thirt" + thirty);
                    thirty = true;
                    Debug.Log("bool thirt" + thirty);
                }
                if (sixtysix.Contains(cc[i]))
                {
                    Debug.Log("bool 6" + sixty);
                    sixty = true;
                    Debug.Log("bool 6" + sixty);
                }
                if (ninety.Contains(cc[i]))
                {
                    Debug.Log("nine" + nine);
                    nine = true;
                    Debug.Log("nine" + nine);
                }
                Debug.Log("cc inside " + cc[i]);
            }

            if (nine == true)
            {
                threatmoney = threatmoney * 0.9;


            }
            if (sixty == true && nine != true)
            {
                threatmoney = threatmoney * 0.66;
            }
            if (sixty == true && nine != true && thirty != true)
            {
                threatmoney = threatmoney * 0.33;
            }
            nine = false;
            thirty = false;
            sixty = false;

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
