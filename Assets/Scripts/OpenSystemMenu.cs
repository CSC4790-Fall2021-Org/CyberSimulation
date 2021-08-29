using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSystemMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    public bool a = false;
    public void popup()
    {
        if (a == false)
        {
            a = true;
            canvas.enabled = true;

        }
        else if (a == true)
        {
            a = false;
            canvas.enabled = false;
        }
    }
}
