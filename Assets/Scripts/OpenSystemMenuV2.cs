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
    public void popup()
    {  

        if (a == false&&EventManage.Instance.nextRound()==true)
        {
            a = true;
            ended = true;
            canvas.enabled = true;
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
