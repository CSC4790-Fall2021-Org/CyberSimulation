//this code was inspired from Brackeys on YouTube

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

	public string cardName;
	public string ciaAspect;

	public Sprite artwork;

	public int moneyValue;

	public void Print ()
	{
		Debug.Log(cardName + ": " + ciaAspect + " The card costs: " + moneyValue);
	}

}