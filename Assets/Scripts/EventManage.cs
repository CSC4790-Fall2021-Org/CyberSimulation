using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
[System.Serializable]

public class EventManage : MonoBehaviour
{
    public static EventManage Instance { get; set; }
    List<int> scenarios = new List<int>();
    [SerializeField]
    List<int> scenariosTemp = new List<int>();
    public int currScenario = 1;

    //  ArrayList scenarioArray = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {

     //   int l = GameObject.Find("System").GetComponent<CSVScript>().ID.Length;

        scenarios = GameObject.Find("System").GetComponent<CSVScript>().ID.ToList();
        //  scenarioArray = new ArrayList(scenarios);
        scenariosTemp = new List<int>(scenarios.Count);
        for (int i = 0; i < scenarios.Count; i++)
        {

            int tempScene = scenarios[Random.Range(0, scenarios.Count)];
            scenariosTemp.Add(tempScene);
            scenarios.Remove(tempScene);
            Debug.Log(tempScene);



        }
    }

    // Update is called once per frame
    void Update()
    {

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
    public int getScenario()
    {

        return scenariosTemp[currScenario];
    }
    public int getIndexOfScenario()
    {
        return scenariosTemp.IndexOf(currScenario);
    }
    public void incrementScenario()
    {
        currScenario++;
    }
    public int getcurrScenario()
    {
        return scenariosTemp[currScenario] - 1;
    }
    public bool nextRound()
    {
        bool temp = GameObject.Find("ChatManager").GetComponent<ChatManager>().checkChoice;
        if (temp == true)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}