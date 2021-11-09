using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class EndRound1 : MonoBehaviour
{

    public int money;
    public Text moneyText1;
    public int dollars;
    public string ff;
    public int initialDollars;
    [SerializeField]
    public string SumText;
    public TextMeshProUGUI SummaryText;
    public GameObject drawCardsButton;
    // Start is called before the first frame update
    void Start()
    {
        drawCardsButton = GameObject.Find("Draw Cards Button");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getSumm()
    {
        SumText = GameObject.Find("System").GetComponent<CSVScript>().endRoundSum[EventManage.Instance.getcurrScenario()];
        string temp = OpenSystemMenuV2.Instance.diff.ToString();

        
        ff = OpenSystemMenuV2.Instance.final + " \n and you have lost $" +temp.Substring(1,temp.Length-1) + "\n";
        SummaryText.text = ff+SumText;
        if(EventManage.Instance.currScenario == 10)
        {
            SummaryText.text = "Congratulations! You have made it to the end. You have $" + OpenSystemMenuV2.Instance.dollars + " left!";
        }
    }

}
