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
    public string[] ddrawc;
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

        string tt = OpenSystemMenuV2.Instance.final;
        SumText = GameObject.Find("System").GetComponent<CSVScript>().endRoundSum[EventManage.Instance.getcurrScenario()];
        double ttt = System.Math.Abs(OpenSystemMenuV2.Instance.diff) + System.Math.Abs(OpenSystemMenuV2.Instance.threatmoney);
        string temp = ttt.ToString();

       
        
            Debug.Log("in lost rn" + OpenSystemMenuV2.Instance.diff);
            ff = OpenSystemMenuV2.Instance.final + " \n and you have lost $" + ttt + " in total and lost $" + OpenSystemMenuV2.Instance.threatmoney + " to the threat" + "\n";
            SummaryText.text = ff + SumText;
            //        GameObject.Find("Money").GetComponent<Text>().text = "100";
            double fff = int.Parse(GameObject.Find("Money").GetComponent<Text>().text);
            fff = fff - OpenSystemMenuV2.Instance.threatmoney;
            GameObject.Find("Money").GetComponent<Text>().text = fff.ToString();

        if (int.Parse(GameObject.Find("Money").GetComponent<Text>().text) < 0)
        {
            SummaryText.text = "GAME OVER";
        }

        if (EventManage.Instance.currScenario == 6)
        {
            SummaryText.text = "Congratulations! You have made it to the end. You have $" + GameObject.Find("Money").GetComponent<Text>().text + " left!";
        }
        
             
    }

}
