using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class CardDescriptionPopup : MonoBehaviour
{
    public GameObject CardDescription;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMenu()
    {
        CardDescription.SetActive(true);
    }

    public void CloseMenu()
    {
        CardDescription.SetActive(false);
    }
}
