using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[System.Serializable]
public class CSVScript : MonoBehaviour
{
    public  TextAsset TextAssetData;
    public string[] description;
    public int[] pool;
    public string[] chat;
    [System.Serializable]
    public class loader
    {
        public string Description;
        public int pool;
        public string chat;

    }
    [System.Serializable]
    public class eventList{
        public loader[] Loader;
    }
    public eventList eventList1 = new eventList();
    // Start is called before the first frame update
    void Awake()
    {
        readCSV();
    }
void readCSV(){

string[] data  = TextAssetData.text.Split(new string[] {",","\n"},StringSplitOptions.None);
int tableSize = data.Length/2-1;
eventList1.Loader = new loader[tableSize];
        description = new string[tableSize];
        pool = new int[tableSize];
        chat = new string[tableSize];
        for (int i =0;i<tableSize;i++){
    eventList1.Loader[i]=new loader(); 
    eventList1.Loader[i].Description = data[3*(i+1)];
            

           // Debug.Log(eventList1.Loader[i].Description);
            eventList1.Loader[i].pool= int.Parse(data[3*(i+1)+1]);
            eventList1.Loader[i].chat = data[3 * (i + 1) + 2];
            //   description[i] = eventList1.Loader[i].Description;


            description[i] = eventList1.Loader[i].Description;
            pool[i] = eventList1.Loader[i].pool;
            chat[i] = eventList1.Loader[i].chat;


        }
        for (int i = 0; i < tableSize; i++)
        {
          
        }


    }
    // Update is called once per frame
   
}
