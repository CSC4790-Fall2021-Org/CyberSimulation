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
    public int currScenario;
  //  ArrayList scenarioArray = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        int l = GameObject.Find("System").GetComponent<CSVScript>().pool.Length;
        scenarios = GameObject.Find("System").GetComponent<CSVScript>().pool.ToList();
=======
      
        int l = GameObject.Find("System").GetComponent<CSVScript>().ID.Length;
        scenarios = GameObject.Find("System").GetComponent<CSVScript>().ID.ToList();
>>>>>>> Stashed changes
      //  scenarioArray = new ArrayList(scenarios);
        scenariosTemp = new List<int>(scenarios.Count);
        for (int i = 0; i < l; i++)
        {
            
            int tempScene = scenarios[Random.Range(0, scenarios.Count)];
            scenariosTemp.Add(tempScene);
            scenarios.Remove(tempScene);
            Debug.Log(tempScene);
            currScenario = tempScene;
            
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

        return currScenario;
    }
    public int getIndexOfScenario()
    {
        return scenariosTemp.IndexOf(currScenario);
    }
}
