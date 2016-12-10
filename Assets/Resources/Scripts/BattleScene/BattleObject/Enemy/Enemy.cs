using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Enemy  : BattleObject{

//	エネミークラスに特有の変数　敵の画像の管理番号
	public string enemyTextureName;

	private string enemyName;
	private int enemyHp;
	private int enemyMp;
	private int enemySTR;
	public int enemyDEF;
	private int enemyAGI;
	private int enemyMoney;
//	private int enemyExp;

//	int current = 0;
	EnemyHashtable enemyHash;
	Hashtable enemyData;
//	UIController uiCon;

	void Awake(){
//		敵の番号を取得して流し込む
//		めんどくさいのでnullチェック方式にした
		string colEnemy = Player.colEnemy;
		if(colEnemy == null){
			int c = Random.Range (1,3);
			if(c == 1){
				enemyData = EnemyHashtable.enemyList["enemy001"];
				Debug.Log ("enemy001");
			}
			if(c == 2){
				enemyData = EnemyHashtable.enemyList["enemy002"];
				Debug.Log ("enemy002");
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
//		enemyExp = (int)enemyData["enemyExp"];

		base.objName = enemyName;
		base.hp = enemyHp;
		base.mp = enemyMp;
		base.strength = enemySTR;
		base.deffence = enemyDEF;
		base.agillity = enemyAGI;
		base.money = enemyMoney;

//		Debug.Log ("敵の名前 : " + enemyName + 
//			"、敵の画像 : " + enemyTextureName +
//			"、敵のHP : " + enemyHp + 
//			"、敵のMP : " + enemyMp +
//			"、敵の攻撃力 : " + enemySTR + 
//			"、敵の防御力 : " + enemyDEF +
//			"、敵の素早さ : " + enemyAGI +
//			"、敵の所持金 : " + enemyMoney);
	}

	void Start(){
//		uiCon = GameObject.Find ("ActionWindow").GetComponent<UIController> ();
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
