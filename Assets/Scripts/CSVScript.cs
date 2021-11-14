using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[System.Serializable]
public class CSVScript : MonoBehaviour
{
    public  TextAsset TextAssetData;
    public int[] ID;
    public string[] chat;
    public string[] choiceA;
    public string[] choiceB;
    public string[] choiceAResult;
    public string[] choiceBResult;
    public string[] endRoundSum;
    public string[] choicecorrect;
    public string[] thirtythree;
          public string[] sixtysix;
    public string[] ninety;
    public int[] threatmoney;
    public string[] SystemInitial;
    public string[] systemCorrect;
  

    [System.Serializable]
    public class loader
    {
       
        public int ID;
      
        public string chat;
        public string choiceA;
        public string choiceB;
        public string choiceAResult;
        public string choiceBResult;
        public string endRoundSum;
        public string choicecorrect;
        public string thirtythree;
        public string sixtysix;
        public string ninety;
        public int threatmoney;
        public string SystemInitial;
        public string systemCorrect;


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
        int l = 14;
string[] data  = TextAssetData.text.Split(new string[] {",","\n"},StringSplitOptions.None);
        for (int i = 0; i < data.Length; i++)
        {
          //  Debug.Log("data i " + data[(i)]);
        }
        int tableSize = data.Length /l-1;
eventList1.Loader = new loader[tableSize];
     
        ID = new int[tableSize];
        chat = new string[tableSize];
        choiceA = new string[tableSize];
        choiceB = new string[tableSize];
        choiceAResult = new string[tableSize];
        choiceBResult = new string[tableSize]; 
        endRoundSum = new string[tableSize]; 
        choicecorrect = new string[tableSize];
        thirtythree = new string[tableSize];
        sixtysix = new string[tableSize]; 
        ninety = new string[tableSize]; 
        threatmoney = new int[tableSize];
        SystemInitial = new string[tableSize];
        systemCorrect = new string[tableSize];

        for (int i =0;i<tableSize;i++){
    eventList1.Loader[i]=new loader();
            eventList1.Loader[i].ID = int.Parse(data[l * (i + 1)]);
            eventList1.Loader[i].chat = data[l * (i + 1) + 1]; 
            eventList1.Loader[i].choiceA = data[l * (i + 1) + 2];
            eventList1.Loader[i].choiceB = data[l * (i + 1) + 3];
            eventList1.Loader[i].choiceAResult = data[l * (i + 1) + 4];
            eventList1.Loader[i].choiceBResult = data[l * (i + 1) + 5];
            eventList1.Loader[i].endRoundSum = data[l * (i + 1) + 6];
            eventList1.Loader[i].choicecorrect = data[l * (i + 1) + 7];
         //   Debug.Log("data " + i + " " + data[l * (i + 1) + 8]);
            eventList1.Loader[i].thirtythree =data[l * (i + 1) + 8];
            eventList1.Loader[i].sixtysix= (data[l * (i + 1) + 9]);
            eventList1.Loader[i].ninety= (data[l * (i + 1) + 10]);
            eventList1.Loader[i].threatmoney = int.Parse(data[l * (i + 1) + 11]);
            eventList1.Loader[i].SystemInitial = data[l * (i + 1) + 12];
            eventList1.Loader[i].systemCorrect = data[l * (i + 1) + 13];
           
            //   description[i] = eventList1.Loader[i].Description;


            
            ID[i] = eventList1.Loader[i].ID;
            chat[i] = eventList1.Loader[i].chat.Replace("COMMA", ",");
            choiceA[i] = eventList1.Loader[i].choiceA;
            choiceB[i] = eventList1.Loader[i].choiceB;
            choiceAResult[i] = eventList1.Loader[i].choiceAResult.Replace("COMMA", ","); //.Replace("QUOTE", "\"");
            choiceBResult[i] = eventList1.Loader[i].choiceBResult.Replace("COMMA", ",");
            endRoundSum[i] = eventList1.Loader[i].endRoundSum.Replace("COMMA", ",");
            choicecorrect[i] = eventList1.Loader[i].choicecorrect;
            thirtythree[i] = eventList1.Loader[i].thirtythree.Replace("COMMA", ",");
            sixtysix[i] = eventList1.Loader[i].sixtysix.Replace("COMMA", ",");
            ninety[i] = eventList1.Loader[i].ninety.Replace("COMMA", ",");
            threatmoney[i] = eventList1.Loader[i].threatmoney;
            SystemInitial[i] = eventList1.Loader[i].SystemInitial.Replace("COMMA", ",");
            systemCorrect[i] = eventList1.Loader[i].systemCorrect.Replace("COMMA", ",");


        }
        for (int i = 0; i < tableSize; i++)
        {
          
        }


    }
    // Update is called once per frame
   
}
