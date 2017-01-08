using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Enemy  : BattleObject{

	//Enemy Status------------------------------------------
	[HideInInspector]
	public string enemyTextureName;

	[HideInInspector]
	public string enemyName;

	[HideInInspector]
	public int enemyHp;

	[HideInInspector]
	public int enemyMp;

	[HideInInspector]
	public int enemySTR;

	[HideInInspector]
	public int enemyDEF;

	[HideInInspector]
	private int enemyAGI;

	[HideInInspector]
	public int enemyMoney;

	[HideInInspector]
	public int enemyExp;
	//-----------------------------------------------------

	Hashtable enemyData;

	void Awake(){
//		敵の番号を取得して流し込む
//		テスト用のnullチェック方式バージョン
		string colEnemy = Player.colEnemy;
		if(colEnemy == null){
			int c = Random.Range (1,3);
			if(c == 1){
				enemyData = EnemyHashtable.enemyList["enemy001"];
			}
			if(c == 2){
				enemyData = EnemyHashtable.enemyList["enemy002"];
			}
		}else if(colEnemy != null){
			enemyData = EnemyHashtable.enemyList[colEnemy];
		}

//		念のため残しておくオリジナル
//		HashTable enemyData = EnemyHashtable.enemyList[colEnemy];

		enemyTextureName = (string)enemyData ["enemyTextureName"];
		enemyName = (string)enemyData ["enemyName"];
		enemyHp = (int)enemyData["enemyHp"];
		enemyMp = (int)enemyData["enemyMp"];
		enemySTR = (int)enemyData["enemySTR"];
		enemyDEF = (int)enemyData["enemyDEF"];
		enemyAGI = (int)enemyData["enemyAGI"];
		enemyMoney = (int)enemyData["enemyMoney"];
		enemyExp = (int)enemyData["enemyExp"];

		base.objName = enemyName;
		base.hp = enemyHp;
		base.mp = enemyMp;
		base.strength = enemySTR;
		base.deffence = enemyDEF;
		base.agillity = enemyAGI;
		base.money = enemyMoney;
	}

	void Start(){
		
	}

	void Update(){

		//配列要素を順番に取り出す---------------------------------------------
//		if(Input.GetKeyDown(KeyCode.E) && current < testNum.Length){
//			Debug.Log ("<color=red>現在の配列長 : </color>" + testNum.Length);
//			Debug.Log ("現在の配列要素 : " + testNum[current]);
//
//			if(current <= testNum.Length){
//				current++;
//			}
//			Debug.Log ("現在のインデックス : " + current);
//		}
		//--------------------------------------------------------------------

//		if(uiCon.isPlayerDecision == true){
//			EnemyDecision ();
//			uiCon.isPlayerDecision = false;
//		}

//		if(Input.GetKeyDown(KeyCode.A)){
//			foreach(Object o in uiCon.actionPriority){
//				Debug.Log(uiCon.actionPriority.IndexOf(o));
//			}
//		☆現在のindexArrayListの場合、IndexOf()の戻り値で帰ってくるっぽい
//			Debug.Log("要素0番 : " + uiCon.actionPriority[0]);
//			Debug.Log("要素1番 : " + uiCon.actionPriority[1]);
//		実際に入っているVallueを確認
//		}

//		actionPriorityに格納したクラスの実体を優先度順に呼び出す-----------------------
//		かつ、キーが押されてから順番に処理を実行する
//		if(Input.GetKeyDown(KeyCode.E) && current < uiCon.actionPriority.Count){
//			if(uiCon.actionPriority[current] is BattlePlayer){
//				Debug.Log ("主人公のターン");
//			}
//
//			if(uiCon.actionPriority[current] is Enemy){
//				Debug.Log ("モンスターのターン");
//			}
//
//			if(current <= uiCon.actionPriority.Count){
//				current++;
//			}
//		}
//		-------------------------------------------------------------------------------
	}

//	void EnemyDecision(){
//		foreach(Object o in uiCon.actionPriority){
//			if (o is BattlePlayer) {
//				BattlePlayer player = (BattlePlayer)o;
//				Debug.Log (player.agillity + " " + this.enemyAGI);
////				((BattlePlayer)o).agillity
////				変数を使わずに直接明示的にキャストする場合はこう↑
//
////				returnを入れるとforeachがその時点で抜ける
////				List<t>にAddしたりInsertするときには、途中で全要素の数が変わるので
////				returnしないとInvalidOperationException
//
//				//自分よりの方が早ければ、敵の実体をListの先頭にInsert
//				if(player.agillity < this.enemyAGI){
//					uiCon.actionPriority.Insert (0,this);
//					return;
//				}
//
//				//自分のほうが素早ければListの末尾に敵の実体をAdd
//				if(player.agillity > this.enemyAGI){
//					uiCon.actionPriority.Add(this);
//					return;
//				}
//			}
//		}
//	}
}
