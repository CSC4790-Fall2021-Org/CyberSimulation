using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NotificationsManager : MonoBehaviour
{
    public TextMeshProUGUI notificationText;
    [SerializeField]
    public int currScenario;
    // Start is called before the first frame update
    private Queue<string> sentences;
    private CSVScript ob;
    public EventManage managetemp;
    public string desc;
    // Update is called once per frame
    void Start()
    {   

        sentences = new Queue<string>();

    }
    public void StartNotifications ()
    {

       int scenario =  EventManage.Instance.getScenario();
       

        if (GameObject.Find("ChatManager").GetComponent<ChatManager>().choicecorrect == false)
        {
            //dialogue.sentence = new string[GameObject.Find("System").GetComponent<CSVScript>().SystemInitial.Length];
            
               desc = GameObject.Find("System").GetComponent<CSVScript>().SystemInitial[EventManage.Instance.getcurrScenario()];
            notificationText.text = desc;

                Debug.Log("swag1" + desc);
            
        }
        else
        {
            desc = GameObject.Find("System").GetComponent<CSVScript>().systemCorrect[EventManage.Instance.getcurrScenario()];
            notificationText.text = desc;
          


                
        }
        
    
    }
  
 
}
