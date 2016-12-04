using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleManager : MonoBehaviour {

	public List<BattleObject> battleObj = new List<BattleObject> ();
	public List<Enemy> enemyOnBattlefield = new List<Enemy>();
	public List<BattlePlayer> playerOnBattlefield = new List<BattlePlayer>();

	void Start () {
		//BattleObject型のリストに敵も味方も全員を格納する
		GameObject[] bObj = GameObject.FindGameObjectsWithTag ("BattleObject");
		foreach(GameObject go in bObj){
			BattleObject battleO;
			if(go.GetComponent<BattlePlayer>() == true){
				battleO = go.GetComponent<BattlePlayer> ();
				battleObj.Add (battleO);
			}else if(go.GetComponent<Enemy>() == true){
				battleO = go.GetComponent<Enemy> ();
				battleObj.Add (battleO);
			}
		}

		//battleObjからプレイヤーとエネミーの実体を分ける
		foreach(BattleObject bo in battleObj){
			if(bo is BattlePlayer){
				//場に存在するプレイヤーだけをリストに格納
				playerOnBattlefield.Add ((BattlePlayer)bo);
			}else if(bo is Enemy){
				//場に存在するエネミーだけをリストに格納
				enemyOnBattlefield.Add ((Enemy)bo);
			}
		}

//		確認用のログ出力テスト
//		foreach(BattlePlayer bp in playerOnBattlefield){
//			Debug.Log(bp);
//		}
//		foreach(Enemy em in enemyOnBattlefield){
//			Debug.Log(em);
//		}

	}

	void Update () {
	
	}
}
