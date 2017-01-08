using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {
	
	protected List<BattleObject> allBattleObj = new List<BattleObject> ();
	protected List<Enemy> enemyOnBattlefield = new List<Enemy>();
	protected List<BattlePlayer> playerOnBattlefield = new List<BattlePlayer>();

//	public bool initiative = false;

	void Awake () {
		//"BattleObject"tagのついているオブジェクトをフィールドから一斉に取得
		GameObject[] bObj = GameObject.FindGameObjectsWithTag ("BattleObject");
		foreach(GameObject gameO in bObj){
			//エネミーとプレイヤーをそれぞれ実体化し、別々の配列に格納
			BattleObject battleO;
			if(gameO.GetComponent<BattlePlayer>() == true){
				battleO = gameO.GetComponent<BattlePlayer> ();
				allBattleObj.Add (battleO);
			}else if(gameO.GetComponent<Enemy>() == true){
				battleO = gameO.GetComponent<Enemy> ();
				allBattleObj.Add (battleO);
			}
		}

		//生成された配列、battleObjからプレイヤーとエネミーの実体を分ける
		foreach(BattleObject bo in allBattleObj){
			if(bo is BattlePlayer){
				//場に存在するプレイヤーだけをリストに格納
				playerOnBattlefield.Add ((BattlePlayer)bo);
			}else if(bo is Enemy){
				//場に存在するエネミーだけをリストに格納
				enemyOnBattlefield.Add ((Enemy)bo);
			}
		}

		//敵味方それぞれをヒエラルキーの順番でソート
		enemyOnBattlefield.Sort ((a,b) => a.transform.GetSiblingIndex() - b.transform.GetSiblingIndex());
		playerOnBattlefield.Sort ((a,b) => a.transform.GetSiblingIndex() - b.transform.GetSiblingIndex());
	}

	void Start(){
		
//		foreach(BattlePlayer pl in playerOnBattlefield){
//			pl.gameObject.GetComponent<BattleObject> ().Attack (pl,enemyOnBattlefield[0],3);
//		}

//		foreach(Enemy em in enemyOnBattlefield){
//			string hoge = (((string)em.name) + " が あらわれた");
//			Debug.Log (hoge);
//		}
	}
}
