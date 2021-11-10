using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummaryTrig : MonoBehaviour
{
    public EndRound1 end;
    // Start is called before the first frame update
    public void TriggerSum()
    {
        if (EventManage.Instance.nextRound() == true)
        {
            end.getSumm();
        }

    }
}
