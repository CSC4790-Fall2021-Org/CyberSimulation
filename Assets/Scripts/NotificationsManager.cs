using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NotificationsManager : MonoBehaviour
{
    public TextMeshProUGUI notificationText;

    // Start is called before the first frame update
    private Queue<string> sentences;
    private CSVScript ob;
    // Update is called once per frame
    void Start()
    {   

        sentences = new Queue<string>();

    }
    public void StartNotifications (Notifications dialogue)
    {
        dialogue.sentence = new string[GameObject.Find("System").GetComponent<CSVScript>().description.Length];
        for (int i = 0; i < GameObject.Find("System").GetComponent<CSVScript>().description.Length; i++)
        {
            dialogue.sentence[i] = GameObject.Find("System").GetComponent<CSVScript>().description[i];
            Debug.Log("swag" + dialogue.sentence[i]);
        }
        foreach (string sentence in dialogue.sentence)
        {
           sentences.Enqueue (sentence);

        }
      
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
        }
        string sentence = sentences.Dequeue();
        notificationText.text = sentence;
    }
    void EndDialogue()
    {

    }
}
