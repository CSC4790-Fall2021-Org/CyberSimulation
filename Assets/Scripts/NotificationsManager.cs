using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NotificationsManager : MonoBehaviour
{
    public TextMeshProUGUI notificationText;

    // Start is called before the first frame update
    private string[] sentences;

    // Update is called once per frame
    void Start()
    {
        sentences = new string[] { };

    }
    public void StartNotifications (Notifications dialogue)
    {
        foreach (string sentence in dialogue.sentences)
        {
            notificationText.text = sentence;
            
        }
    }
}
