using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDataBase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

	private void Awake()
	{
		//Bonus
		cardList.Add(new Card(0, "Bonus", 15, "Black", "ChangeColor"));
		cardList.Add(new Card(1, "Bonus", 15, "Black", "+4"));
		cardList.Add(new Card(42, "Bonus", 10, "Red", "+2"));
		cardList.Add(new Card(43, "Bonus", 10, "Yelow", "+2"));
		cardList.Add(new Card(44, "Bonus", 10, "Green", "+2"));
		cardList.Add(new Card(45, "Bonus", 10, "Blue", "+2"));
		cardList.Add(new Card(46, "Bonus", 10, "Red", "ChangeDirection"));
		cardList.Add(new Card(47, "Bonus", 10, "Yelow", "ChangeDirection"));
		cardList.Add(new Card(48, "Bonus", 10, "Green", "ChangeDirection"));
		cardList.Add(new Card(49, "Bonus", 10, "Blue", "ChangeDirection"));
		cardList.Add(new Card(50, "Bonus", 10, "Red", "Cencel"));
		cardList.Add(new Card(51, "Bonus", 10, "Yelow", "Cencel"));
		cardList.Add(new Card(52, "Bonus", 10, "Green", "Cencel"));
		cardList.Add(new Card(53, "Bonus", 10, "Blue", "Cencel"));
		//0
		cardList.Add(new Card(2, "Digit", 0, "Red", "None"));
		cardList.Add(new Card(3, "Digit", 0, "Yelow", "None"));
		cardList.Add(new Card(4, "Digit", 0, "Green", "None"));
		cardList.Add(new Card(5, "Digit", 0, "Blue", "None"));
		//1
		cardList.Add(new Card(6, "Digit", 1, "Red", "None"));
		cardList.Add(new Card(7, "Digit", 1, "Yelow", "None"));
		cardList.Add(new Card(8, "Digit", 1, "Green", "None"));
		cardList.Add(new Card(9, "Digit", 1, "Blue", "None"));
		//2
		cardList.Add(new Card(10, "Digit", 2, "Red", "None"));
		cardList.Add(new Card(11, "Digit", 2, "Yelow", "None"));
		cardList.Add(new Card(12, "Digit", 2, "Green", "None"));
		cardList.Add(new Card(13, "Digit", 2, "Blue", "None"));
		//3
		cardList.Add(new Card(14, "Digit", 3, "Red", "None"));
		cardList.Add(new Card(15, "Digit", 3, "Yelow", "None"));
		cardList.Add(new Card(16, "Digit", 3, "Green", "None"));
		cardList.Add(new Card(17, "Digit", 3, "Blue", "None"));
		//4
		cardList.Add(new Card(18, "Digit", 4, "Red", "None"));
		cardList.Add(new Card(19, "Digit", 4, "Yelow", "None"));
		cardList.Add(new Card(20, "Digit", 4, "Green", "None"));
		cardList.Add(new Card(21, "Digit", 4, "Blue", "None"));
		//5
		cardList.Add(new Card(22, "Digit", 5, "Red", "None"));
		cardList.Add(new Card(23, "Digit", 5, "Yelow", "None"));
		cardList.Add(new Card(24, "Digit", 5, "Green", "None"));
		cardList.Add(new Card(25, "Digit", 5, "Blue", "None"));
		//6
		cardList.Add(new Card(26, "Digit", 6, "Red", "None"));
		cardList.Add(new Card(27, "Digit", 6, "Yelow", "None"));
		cardList.Add(new Card(28, "Digit", 6, "Green", "None"));
		cardList.Add(new Card(29, "Digit", 6, "Blue", "None"));
		//7
		cardList.Add(new Card(30, "Digit", 7, "Red", "None"));
		cardList.Add(new Card(31, "Digit", 7, "Yelow", "None"));
		cardList.Add(new Card(32, "Digit", 7, "Green", "None"));
		cardList.Add(new Card(33, "Digit", 7, "Blue", "None"));
		//8
		cardList.Add(new Card(34, "Digit", 8, "Red", "None"));
		cardList.Add(new Card(35, "Digit", 8, "Yelow", "None"));
		cardList.Add(new Card(36, "Digit", 8, "Green", "None"));
		cardList.Add(new Card(37, "Digit", 8, "Blue", "None"));
		//9
		cardList.Add(new Card(38, "Digit", 9, "Red", "None"));
		cardList.Add(new Card(39, "Digit", 9, "Yelow", "None"));
		cardList.Add(new Card(40, "Digit", 9, "Green", "None"));
		cardList.Add(new Card(41, "Digit", 9, "Blue", "None"));
	}
}
