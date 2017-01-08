using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class CharInit : MonoBehaviour {

	GameObject status;
	List<Text> stateText = new List<Text>();
	BattlePlayer player;

	void Awake(){
		//生成された時点での位置を初期化
	}

	void Start () {
		status = transform.GetChild (0).gameObject;
		player = this.GetComponent<BattlePlayer> ();

		foreach (Transform t in status.transform) {
			stateText.Add (t.gameObject.GetComponent<Text>());
		}
	}

	void Update () {
		stateText [0].text = player.playerName;
		stateText [1].text = "HP : " + player.playerHp.ToString();
		stateText [2].text = "MP : " + player.playerMp.ToString();
		stateText [3].text = "Lv." + player.playerLv.ToString();
	}

	void StatusPositionInit(){
		//位置を初期化
	}
}