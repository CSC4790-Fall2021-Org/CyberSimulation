using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
[System.Serializable]
public class EndRound1 : MonoBehaviour

{
    [SerializeField]
    public TextMeshProUGUI SummaryText;
    public string SumText;
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
        SumText = GameObject.Find("System").GetComponent<CSVScript>().description[EventManage.Instance.getcurrScenario()];
        SummaryText.text = SumText;
    }
}
