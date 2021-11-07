using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[System.Serializable]
public class EndRound1 : MonoBehaviour
{
    [SerializeField]
    public string SumText;
    public TextMeshProUGUI SummaryText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getSumm()
    {
        SumText = GameObject.Find("System").GetComponent<CSVScript>().endRoundSum[EventManage.Instance.getcurrScenario()];
        SummaryText.text = SumText;
    }

}
