using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleManager : MonoBehaviour {

//	public List<BattleObject> allBattleObj = new List<BattleObject> ();
//	public List<Enemy> enemyOnBattlefield = new List<Enemy>();
//	public List<BattlePlayer> playerOnBattlefield = new List<BattlePlayer>();
//
//	void Start () {
//		//"BattleObject"tagのついているオブジェクトをフィールドから一斉に取得
//		GameObject[] bObj = GameObject.FindGameObjectsWithTag ("BattleObject");
//		foreach(GameObject gameO in bObj){
//			//ついでにエネミーとプレイヤーをそれぞれ実体化
//			BattleObject battleO;
//			if(gameO.GetComponent<BattlePlayer>() == true){
//				battleO = gameO.GetComponent<BattlePlayer> ();
//				allBattleObj.Add (battleO);
//			}else if(gameO.GetComponent<Enemy>() == true){
//				battleO = gameO.GetComponent<Enemy> ();
//				allBattleObj.Add (battleO);
//			}
//		}
//
//		//生成された配列、battleObjからプレイヤーとエネミーの実体を分ける
//		foreach(BattleObject bo in allBattleObj){
//			if(bo is BattlePlayer){
//				//場に存在するプレイヤーだけをリストに格納
//				playerOnBattlefield.Add ((BattlePlayer)bo);
//			}else if(bo is Enemy){
//				//場に存在するエネミーだけをリストに格納
//				enemyOnBattlefield.Add ((Enemy)bo);
//			}
//		}
//	}

	void Update () {
		
	}
}
