using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Referenced from sushanta1991.blogspot.com

public class ChatManager : MonoBehaviour
{
    [SerializeField] private Transform content;
    [SerializeField] private GameObject chatBarPrefab;
    [SerializeField] private Color playerChatColor;
    [SerializeField] private Color cpuChatColor;
    [SerializeField] public bool checkChoice = false;
    [SerializeField] private Sprite playerChatBar;
    [SerializeField] private Sprite cpuChatBar;
    [SerializeField] private Canvas chatCanvas;
    [SerializeField] private Sprite userSprite;
    [SerializeField] private Text choiceAButtonText;
    [SerializeField] private Text choiceBButtonText;


    private string[] initialChatTexts = new string[1];
    private string[] choiceAChatTexts= new string[1];
    private string[] choiceBChatTexts= new string[1];
  
    public bool initial = false;
    private string choiceA;
    public string correctChoice = "";
    public bool choicecorrect = false;

    private string choiceB;
    private int fontSize;
    private string lastUser;

    private VerticalLayoutGroup verticalLayoutGroup;

    AudioSource correctAudio;
    AudioSource wrongAudio;

    public Font myNewFont;

    // Start is called before the first frame update
    void Start()
    {
        correctAudio = GameObject.Find("Correct Sound").GetComponent<AudioSource>();
        wrongAudio = GameObject.Find("Wrong Sound").GetComponent<AudioSource>();
        /*
        verticalLayoutGroup = content.GetComponent<VerticalLayoutGroup>();
        chatCanvas.enabled = false;
        initialChatTexts = new string[GameObject.Find("System").GetComponent<CSVScript>().description.Length];
        for (int i = 0; i < GameObject.Find("System").GetComponent<CSVScript>().description.Length; i++)
        {
            initialChatTexts[i] = GameObject.Find("System").GetComponent<CSVScript>().description[i];
            Debug.Log("swa22g" + initialChatTexts[i]);
        }

        choiceAChatTexts = new string[]
        {
            "Sounds about right"
        };

        choiceBChatTexts = new string[]
        {
            "Hmm, not sure if it sounds like a mishing attack"
        };

        choiceA = "Phishing";
        choiceB = "Mishing";
        choiceAButtonText.text = choiceA;
        choiceBButtonText.text = choiceB;

        ShowMessages(initialChatTexts, 1);
        */
    }
    public void cc()
    {
 
        if (checkChoice == true && OpenSystemMenuV2.Instance.ended == true)
        {
            initial = false;
            checkChoice = false;
            correctChoice = "";
            choicecorrect = false;
        }
        correctChoice = GameObject.Find("System").GetComponent<CSVScript>().choicecorrect[EventManage.Instance.getcurrScenario()];
               verticalLayoutGroup = content.GetComponent<VerticalLayoutGroup>();
        chatCanvas.enabled = false;
        initialChatTexts = new string[1];
        
            
            initialChatTexts[0] = GameObject.Find("System").GetComponent<CSVScript>().chat[EventManage.Instance.getcurrScenario()];
            Debug.Log("swa22g" + initialChatTexts.Length);
        
        /*
>>>>>>> Stashed changes
        choiceAChatTexts = new string[]
        {
               
    };

        choiceBChatTexts = new string[]
        {
            "Hmm, not sure if it sounds like a mishing attack"
        };
        
        choiceA = "Phishing";
        choiceB = "Mishing";
        */
        choiceA = GameObject.Find("System").GetComponent<CSVScript>().choiceA[EventManage.Instance.getcurrScenario()];
      choiceB=GameObject.Find("System").GetComponent<CSVScript>().choiceB[EventManage.Instance.getcurrScenario()];

        

            choiceAChatTexts[0] = GameObject.Find("System").GetComponent<CSVScript>().choiceAResult[EventManage.Instance.getcurrScenario()];
         
        
        for (int i = 0; i < choiceAChatTexts.Length; i++)
        {

            choiceBChatTexts[i] = GameObject.Find("System").GetComponent<CSVScript>().choiceBResult[EventManage.Instance.getcurrScenario()];

        }

        choiceAButtonText.text = choiceA;
        choiceBButtonText.text = choiceB;
        if (initial == false)
        {
            ShowMessages(initialChatTexts, 1);
            initial = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
      
    }

    void ShowMessages(string[] data, int side)
    {
        //for (int i = 0; i < data.Length; i++)
       // {
            StartCoroutine(ShowMessageCoroutine(data[0], side));
       // }
    }

    IEnumerator ShowMessageCoroutine(string msg, int side)
    {
        GameObject chatObj = Instantiate(chatBarPrefab, Vector3.zero, Quaternion.identity) as GameObject;
        chatObj.transform.SetParent(content.transform, false);
        chatObj.SetActive(true);
        ChatListObject clb = chatObj.GetComponent<ChatListObject>();
        fontSize = (int)(Screen.height * 0.03f);

        //clb.parentText.font = myNewFont;

        clb.parentText.fontSize = fontSize;
        clb.childText.fontSize = fontSize;
        clb.parentText.text = msg;

        clb.childText.color = Color.black;

        yield return new WaitForEndOfFrame();

        float height = chatObj.GetComponent<RectTransform>().rect.height;
        float width = chatObj.GetComponent<RectTransform>().rect.width;

        clb.chatbarImage.rectTransform.sizeDelta = new Vector2(width + 5, height + 6);
        clb.childText.rectTransform.sizeDelta = new Vector2(width, height);


        clb.childText.text = msg;

        if (side == 0)
        {
            if (lastUser == "1")
            {
                clb.userImage.enabled = true;
            }
            else if (lastUser == "0")
            {
                clb.userImage.enabled = false;
            }
            clb.chatbarImage.color = new Color(playerChatColor.r, playerChatColor.g, playerChatColor.b, 1);
            clb.userImage.sprite = userSprite;

            clb.chatbarImage.sprite = playerChatBar;

            clb.userImage.transform.parent.GetComponent<RectTransform>().anchoredPosition = new Vector2(-26f, clb.userImage.transform.parent.GetComponent<RectTransform>().anchoredPosition.y);
            clb.chatbarImage.rectTransform.anchoredPosition = new Vector2(-3f, clb.chatbarImage.rectTransform.anchoredPosition.y);

            lastUser = "0";
        }
        else if (side == 1)
        {
            if (lastUser == "0")
            {
                clb.userImage.enabled = true;
            }
            else if (lastUser == "1")
            {
                clb.userImage.enabled = false;
            }

            clb.chatbarImage.color = new Color(cpuChatColor.r, cpuChatColor.g, cpuChatColor.b, 1);
            clb.userImage.sprite = userSprite;

            clb.chatbarImage.sprite = cpuChatBar;

            clb.chatbarImage.rectTransform.anchoredPosition = new Vector2(((content.GetComponent<RectTransform>().rect.width - (verticalLayoutGroup.padding.left + verticalLayoutGroup.padding.right)) - chatObj.GetComponent<RectTransform>().rect.width), clb.chatbarImage.rectTransform.anchoredPosition.y);
            clb.userImage.transform.parent.GetComponent<RectTransform>().anchoredPosition = new Vector2(clb.chatbarImage.rectTransform.anchoredPosition.x + clb.parentText.rectTransform.rect.width + 27, clb.userImage.transform.parent.GetComponent<RectTransform>().anchoredPosition.y);
            lastUser = "1";
        }
    }

    public void ShowChat()
    {
        chatCanvas.enabled = true;
    }

    public void ExitChat()
    {
        chatCanvas.enabled = false;
    }

    public void ChoiceA()
    {
        if (checkChoice == false)
        {
            wrongAudio.Play(0);
            StartCoroutine(ShowMessageCoroutine(choiceA, 0));
            ShowMessages(choiceAChatTexts, 1);
            checkChoice = true;
            if (correctChoice == "A")
            {
                correctAudio.Play(0);
                choicecorrect = true;
            }
            Debug.Log("checkchoice = " + checkChoice);

        }
    }

    public void ChoiceB()
    {
        if (checkChoice == false)
        {
            wrongAudio.Play(0);
            StartCoroutine(ShowMessageCoroutine(choiceB, 0));
            ShowMessages(choiceBChatTexts, 1);
            checkChoice = true;
            if (correctChoice == "B")
            {
                correctAudio.Play(0);
                choicecorrect = true;
            }
            Debug.Log("checkchoice = " + checkChoice);

        }
    }
    
}
