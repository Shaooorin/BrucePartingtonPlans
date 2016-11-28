using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyHashtable {
//	↑ Monoの継承がないので注意

	//まずstaticなDictionaryをつくる
	//キーはstring、値はhashtableで敵オブジェクトのstringをキーにhashを取得
	public static Dictionary<string,Hashtable> enemyList = new Dictionary<string,Hashtable>();

	public static Hashtable enemy001_data = new Hashtable();
	public static Hashtable enemy002_data = new Hashtable();

//	hashがAddされたり、ListがAddされるタイミングに注意
//	特にListがないのにAddしたり、その逆に注意
//	staticなコンストラクタ(1回しか実行されない)としてListやHashの実数値が生成される
//	2回やると当然エラーはしるのでこれも注意

//	public void EnemyStatusInit(){
	static EnemyHashtable(){
		
		enemyList.Add("enemy001",enemy001_data);

		enemy001_data.Add ("enemyTextureName","Clouds");
		enemy001_data.Add ("enemyName","くも");
		enemy001_data.Add ("enemyHp",50);
		enemy001_data.Add ("enemyMp",50);
		enemy001_data.Add ("enemySTR",50);
		enemy001_data.Add ("enemyDEF",50);
		enemy001_data.Add ("enemyAGI",50);
		enemy001_data.Add ("enemyMoney",0);
		enemy001_data.Add ("enemyExp",50);

		//------------------------------------------------------------------------------

		enemyList.Add ("enemy002",enemy002_data);

		enemy002_data.Add ("enemyTextureName","enemy_dog");
		enemy002_data.Add ("enemyName","いぬ");
		enemy002_data.Add ("enemyHp",80);
		enemy002_data.Add ("enemyMp",80);
		enemy002_data.Add ("enemySTR",80);
		enemy002_data.Add ("enemyDEF",80);
		enemy002_data.Add ("enemyAGI",80);
		enemy002_data.Add ("enemyMoney",0);
		enemy002_data.Add ("enemyExp",80);

		//------------------------------------------------------------------------------
	}
}