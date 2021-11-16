using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
[System.Serializable]

public class GameOverPopup : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject WinScreen;
    public GameObject EndScreen;
    public GameObject drawCardsButton;

    AudioSource gameTheme;

    public GameObject dayGameOver;
    public GameObject winMoney;

    AudioSource winSound;
    AudioSource loseSound;

    public bool canPlayWin;
    public bool canPlayLoss;

    // Start is called before the first frame update
    void Start()
    {
        drawCardsButton = GameObject.Find("Draw Cards Button");
        EndScreen = GameObject.Find("EndRound");

        gameTheme = GameObject.Find("Background Music").GetComponent<AudioSource>();
        winSound = GameObject.Find("Win Sound").GetComponent<AudioSource>();
        loseSound = GameObject.Find("Lose Sound").GetComponent<AudioSource>();

        dayGameOver.GetComponent<Text>().text = "1";
        winMoney.GetComponent<Text>().text = "50";

        canPlayWin = true;
        canPlayLoss = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(GameObject.Find("Money").GetComponent<Text>().text) < 1)
        {
            drawCardsButton.GetComponent<DrawCardsV2>().canShuffle = false;

            gameTheme.Pause();
            
            if(canPlayLoss == true)
            {
                loseSound.Play();
                canPlayLoss = false;
            }

            dayGameOver.GetComponent<Text>().text = GameObject.Find("Day Number").GetComponent<Text>().text;

            Invoke("OpenGameOver()", 1);
            GameOver.SetActive(true);
            EndScreen.SetActive(false);
        }

        if(drawCardsButton.GetComponent<DrawCardsV2>().dayNum > 6)
        {
            gameTheme.Pause();

            if(canPlayWin == true)
            {
                winSound.Play();
                canPlayWin = false;
            }

            winMoney.GetComponent<Text>().text = GameObject.Find("Money").GetComponent<Text>().text;

            Invoke("OpenWin()", 1);
            WinScreen.SetActive(true);
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

    public void OpenWin()
    {
        WinScreen.SetActive(true);
    }
}
