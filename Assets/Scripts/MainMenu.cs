using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void qq()
    {
        if (EventManage.Instance.currScenario == 6 || double.Parse(GameObject.Find("Money").GetComponent<Text>().text)<0)
        {
            QuitGame();
        }
    }
}
