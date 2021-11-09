using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[System.Serializable]
public class CSVScriptCard : MonoBehaviour
{
    public TextAsset TextAssetData;
    public string[] ID;
    public string[] cardName;
    public string[] cardDescription;
  


    [System.Serializable]
    public class loader
    {

        public string ID;

        public string cardName;
        public string cardDescription;


    }
    [System.Serializable]
    public class eventList
    {
        public loader[] Loader;
    }
    public eventList eventList1 = new eventList();
    // Start is called before the first frame update
    void Awake()
    {
        readCSV();
    }
    void readCSV()
    {
        int l = 3;
        string[] data = TextAssetData.text.Split(new string[] { ",", "\n" }, StringSplitOptions.None);
        for (int i = 0; i < data.Length; i++)
        {
            //  Debug.Log("data i " + data[(i)]);
        }
        int tableSize = data.Length / l - 1;
        eventList1.Loader = new loader[tableSize];

        ID = new string[tableSize];
        cardName = new string[tableSize];
        cardDescription = new string[tableSize];
       

        for (int i = 0; i < tableSize; i++)
        {
            eventList1.Loader[i] = new loader();
            eventList1.Loader[i].ID = data[l * (i + 1)];
            eventList1.Loader[i].cardName = data[l * (i + 1) + 1];
            eventList1.Loader[i].cardDescription = data[l * (i + 1) + 2];
            

            //   description[i] = eventList1.Loader[i].Description;



            ID[i] = eventList1.Loader[i].ID;
            cardName[i] = eventList1.Loader[i].cardName.Replace("COMMA", ",");
            cardDescription[i] = eventList1.Loader[i].cardDescription.Replace("COMMA", ",");
          


        }
        for (int i = 0; i < tableSize; i++)
        {

        }


    }
    // Update is called once per frame

}
