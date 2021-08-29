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

    [SerializeField] private Sprite playerChatBar;
    [SerializeField] private Sprite cpuChatBar;
    [SerializeField] private Canvas chatCanvas;
    [SerializeField] private Sprite userSprite;
    [SerializeField] private Text choiceAButtonText;
    [SerializeField] private Text choiceBButtonText;

    private string[] initialChatTexts;
    private string[] choiceAChatTexts;
    private string[] choiceBChatTexts;
    private string choiceA;
    private string choiceB;
    private int fontSize;
    private string lastUser;

    private VerticalLayoutGroup verticalLayoutGroup;

    // Start is called before the first frame update
    void Start()
    {
        verticalLayoutGroup = content.GetComponent<VerticalLayoutGroup>();
        chatCanvas.enabled = false;
        initialChatTexts = new string[]
        {
            "I received an email message that looked very similar to Gmail, urging me to update my security credentials. Once I clicked on the link, I was prompted to input my username and password, but the format of the website looked different from the normal Gmail interface."
        };

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
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShowMessages(string[] data, int side)
    {
        for (int i = 0; i < data.Length; i++)
        {
            StartCoroutine(ShowMessageCoroutine(data[i], side));
        }
    }

    IEnumerator ShowMessageCoroutine(string msg, int side)
    {
        GameObject chatObj = Instantiate(chatBarPrefab, Vector3.zero, Quaternion.identity) as GameObject;
        chatObj.transform.SetParent(content.transform, false);
        chatObj.SetActive(true);
        ChatListObject clb = chatObj.GetComponent<ChatListObject>();
        fontSize = (int)(Screen.height * 0.03f);
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
        StartCoroutine(ShowMessageCoroutine(choiceA, 0));
        ShowMessages(choiceAChatTexts, 1);
    }

    public void ChoiceB()
    {
        StartCoroutine(ShowMessageCoroutine(choiceB, 0));
        ShowMessages(choiceBChatTexts, 1);
    }
}
