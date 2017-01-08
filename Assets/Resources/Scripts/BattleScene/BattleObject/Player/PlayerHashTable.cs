using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerHashTable {
	
	public static Dictionary<string,Hashtable> playerList = new Dictionary<string,Hashtable>();

	public static Hashtable player001_data = new Hashtable();
	public static Hashtable player002_data = new Hashtable();

	static PlayerHashTable(){
		
		playerList.Add("player001",player001_data);

		player001_data.Add ("playerName","Jhon");
		player001_data.Add ("playerLV",5);
		player001_data.Add ("playerHp",120);
		player001_data.Add ("playerMp",120);
		player001_data.Add ("playerSTR",50);
		player001_data.Add ("playerDEF",80);
		player001_data.Add ("playerAGI",90);
		player001_data.Add ("playerEXP",0);

		//------------------------------------------------------------------------------

		playerList.Add ("player002",player002_data);

		player002_data.Add ("playerName","Paul");
		player002_data.Add ("playerLV",3);
		player002_data.Add ("playerHp",145);
		player002_data.Add ("playerMp",120);
		player002_data.Add ("playerSTR",100);
		player002_data.Add ("playerDEF",30);
		player002_data.Add ("playerAGI",70);
		player002_data.Add ("playerEXP",0);

		//------------------------------------------------------------------------------
	}
}
