using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSystemMenuV2 : MonoBehaviour
{
    public static OpenSystemMenuV2 Instance { get; set; }
    // Start is called before the first frame update
    public Canvas canvas;
    public bool a = false;
    public bool b = false;
    public bool ended = false;
    public int final;
    public int threatmoney;
    public int[] thirtt;
    public int[] sixtysix;
    public int[] ninety;
    public void popup()
    {  

        if (a == false&&EventManage.Instance.nextRound()==true)
        {
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
            string [] values1 = temp.Split(",".ToCharArray());

            int[] ninety = new int[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                ninety[i] = int.Parse(values1[i]);
                Debug.Log("ss " + values1[i]);
            }

            


            EventManage.Instance.incrementScenario();


        }
        else if (a == true)
        {
            a = false;
            canvas.enabled = false;
        }
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
