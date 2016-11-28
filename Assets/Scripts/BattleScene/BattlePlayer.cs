using UnityEngine;
using System.Collections;

public class BattlePlayer : BattleObject {

	public string playerName = "つるたろう";
	private int playerLevel = 1;
	private int playerHp = 100;
	private int playerMp = 000;
	private int playerStrength = 25;
	private int playerDeffence = 50;
	private int playerAgillity = 100;
	private int playerMoney = 3000;

//	Enemy enemy;

	void Awake(){
		base.objName = playerName;
		base.level = playerLevel;
		base.hp = playerHp;
		base.mp = playerMp;
		base.strength = playerStrength;
		base.deffence = playerDeffence;
		base.agillity = playerAgillity;
		base.money = playerMoney;
//		enemy = GameObject.Find ("Enemy").GetComponent<Enemy> ();
	}

	void Start () {
//		Attack (this, CulcuratedDamage(this.strength,enemy.deffence));
	}

	void Update () {
	}
}
