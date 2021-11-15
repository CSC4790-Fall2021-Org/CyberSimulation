using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class CreditsScript : MonoBehaviour
{
    public GameObject Credits;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenCredits()
    {
        Credits.SetActive(true);
    }

    public void CloseCredits()
    {
        Credits.SetActive(false);
    }
}
