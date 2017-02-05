using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattlePlayer : BattleObject {

	[HideInInspector]
	public string playerName;

	[HideInInspector]
	public int playerLv;

	[HideInInspector]
	public int playerHp;

	[HideInInspector]
	public int playerMp;

	[HideInInspector]
	public int playerSTR;

	[HideInInspector]
	public int playerDEF;

	[HideInInspector]
	public int playerAGI;

	[HideInInspector]
	public int playerEXP;

//	PlayerHashTable plaerHash;
	Hashtable playerData;

	void Awake(){
		int c = Random.Range (1,3);
		if(c == 1){
			playerData = PlayerHashTable.playerList["player001"];
		}
		if(c == 2){
			playerData = PlayerHashTable.playerList["player002"];
		}

		playerName = (string)playerData["playerName"];
		playerLv = (int)playerData["playerLV"];
		playerHp = (int)playerData["playerHp"];
		playerMp = (int)playerData["playerMp"];
		playerSTR = (int)playerData["playerSTR"];
		playerDEF = (int)playerData["playerDEF"];
		playerAGI = (int)playerData["playerAGI"];
		playerEXP = (int)playerData["playerEXP"];

		base.objName = playerName;
		base.level = playerLv;
		base.hp = playerHp;
		base.mp = playerMp;
		base.strength = playerSTR;
		base.deffence = playerDEF;
		base.agillity = playerAGI;
		base.experience = playerEXP;

//		それぞれの持つ技の管理(テスト用/こうやって使うメモ)　
//		for(int i = 0;i < 5;i++){
//			this.playerSkill.Add ((int)Random.Range(1,6));
//		}
//		foreach(int ps in base.playerSkill){
//			Debug.Log (playerName + "の技" + ps +" : " + SkillDictionary.skillDic[ps][2]);
//		}

		for(int i = 1; i < ((int)(Random.Range(1,6))); i++){
			base.playerSkill.Add (i);
		}
	}

	void Start () {
		
	}

}
