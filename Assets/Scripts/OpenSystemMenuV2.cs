using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSystemMenuV2 : MonoBehaviour
{
    
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
}
