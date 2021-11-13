using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class HelpButton : MonoBehaviour
{
    AudioSource clickEnter;
    AudioSource clickExit;

    public GameObject Hints;

    // Start is called before the first frame update
    void Start()
    {
        clickEnter = GameObject.Find("Enter Click Sound").GetComponent<AudioSource>();
        clickExit = GameObject.Find("Exit Click Sound").GetComponent<AudioSource>();

    }

    public void OpenCloseHints()
    {
        if(Hints.active == true)
        {
            clickExit.Play(0);
            Hints.SetActive(false);
        }
        else if(Hints.active == false)
        {
            clickEnter.Play(0);
            Hints.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
