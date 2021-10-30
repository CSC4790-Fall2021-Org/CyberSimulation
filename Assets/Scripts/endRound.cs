using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class endRound : MonoBehaviour
{
    public static endRound Instance { get; set; }
    [SerializeField]
    public bool checkEndRound=false;
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkend()
    {
        bool temp = GameObject.Find("Chat").GetComponent<ChatManager>().checkChoice;
        

    }
    void Awake()
    {

        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

}
