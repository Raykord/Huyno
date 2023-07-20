using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Card : MonoBehaviour
{
    public int id;
    public string cardType;
    public int cost;
    public string cardColor;
    public string cardEffect;

    public Card()
    {

    }

    public Card(int id, string cardType, int cost, string cardColor, string cardEffect)
	{
		this.id = id;
		this.cardType = cardType;
		this.cost = cost;
		this.cardColor = cardColor;
		this.cardEffect = cardEffect;
	}
}
