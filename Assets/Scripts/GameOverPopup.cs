using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class GameOverPopup : MonoBehaviour
{
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(GameObject.Find("Money").GetComponent<Text>().text) < 1)
        {
            GameOver.SetActive(true);
        }
    }

    public void OpenGameOver()
    {
        GameOver.SetActive(true);
    }

    public void CloseGameOver()
    {
        GameOver.SetActive(false);
    }
}
