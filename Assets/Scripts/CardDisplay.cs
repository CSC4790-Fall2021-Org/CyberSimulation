//this code is inspired from Brackeys on YouTube

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour {

	public Card card;

	public Text nameText;
	public Text ciaText;

	public Image artworkImage;

	public Text moneyValue;

	// Use this for initialization
	void Start () {
        card.Print();

		nameText.text = card.cardName;
		ciaText.text = card.ciaAspect;

		artworkImage.sprite = card.artwork;

		moneyValue.text = card.moneyValue.ToString();

	}
	
}