using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyHashtable {
//	↑ MonoBehaiviourの継承がないので注意

	//まずstaticなDictionaryをつくる(敵のステータスの値は基本的に変わらないのでstatic)
	//キーはstring、値はhashtableで敵オブジェクトのstringをキーにhashを取得
	public static Dictionary<string,Hashtable> enemyList = new Dictionary<string,Hashtable>();

	//次に今つくった連想配列に二次元要素をこちらも同じく連想配列として追加する
	public static Hashtable enemy001_data = new Hashtable();
	public static Hashtable enemy002_data = new Hashtable();

//	hashがAddされたり、ListがAddされるタイミングに注意
//	まず大元の配列に要素をAddした後に、二次元配列の要素をAddする
//	同じリストに同じ鍵を持つ要素が2度Addされると例外が走るのでstaticコンストラクタで実行

	static EnemyHashtable(){
		//colEnemyとして取得されるstring文字列とリストの鍵を一致させる
		enemyList.Add("enemy001",enemy001_data);

		enemy001_data.Add ("enemyTextureName","EnemyImage/image_enemy001");
		enemy001_data.Add ("enemyName","みっこくしゃ");
		enemy001_data.Add ("enemyHp",50);
		enemy001_data.Add ("enemyMp",50);
		enemy001_data.Add ("enemySTR",50);
		enemy001_data.Add ("enemyDEF",50);
		enemy001_data.Add ("enemyAGI",50);
		enemy001_data.Add ("enemyMoney",0);
		enemy001_data.Add ("enemyExp",50);

		//------------------------------------------------------------------------------

		enemyList.Add ("enemy002",enemy002_data);

		enemy002_data.Add ("enemyTextureName","EnemyImage/image_enemy002");
		enemy002_data.Add ("enemyName","いんぼうろん");
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