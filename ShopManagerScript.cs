using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopManagerScript : MonoBehaviour
{
	public int[,] shopItems = new int[5,5];
	public float coins; //Ben geçici bir coin sistemi yapyım ama bizimkilermile bağlayın siz
	public Text CoinsTXT;
	
	
	void Start()
	{
		CoinsTXT.text = "Coins: " + coins.ToString();
		
		//ID'ler
		shopItems[1,1] =1;
	    shopItems[1,2] =2;
	    shopItems[1,3] =3;
	    shopItems[1,4] =4;
		
		
		//Fiyat
		shopItems[2,1] = 10;//Fiyatlarda aynı şekilde öylesine koydum şimdilik
		shopItems[2,2] = 20;
	    shopItems[2,3] = 30;
	    shopItems[2,4] = 40;
		
		
		//Sayısı (Sahip olma açısından)
		shopItems[3,1] = 0;
	    shopItems[3,2] = 0;
	    shopItems[3,3] = 0;
	    shopItems[3,4] = 0;
	}
	
	public void Buy()
	{
		GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;
		
		if(coins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
		{
			coins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
			
			shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
			
			CoinsTXT.text = "Coins: " + coins.ToString();
			
			ButtonRef.GetComponent<ButtonRef>().QuantityText.text = shopItems[3,ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();
		}
	}
}