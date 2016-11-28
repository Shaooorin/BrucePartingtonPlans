using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	int[] hogehoge = new int[4];
	int i = 0;
	int winNum;
//	GameObject[] actWin;

	int current = 0;

	Color red = new Color (255f,0f,0f,255f);
	Color invisi = new Color(0f,0f,0f,0f);

	public ArrayList actionPriority = new ArrayList ();

	Image fightMenu;
	Image itemMenu;
	Image magicMenu;
	Image runawayMenu;
	Text fightWinText;
	BattleController battleCon;
	BattlePlayer battlePlayer;
//	Enemy enemy;
	GameObject fightWin;

	public bool isPlayerDecision = false;

//	↓入力の受付状態を管理する適当なEnum型変数
	public enum InputMode {
		ACTIVE,
		NON_ACTIVE,
		NEUTRAL
	}
	public InputMode inputMode;

	void Start () {
//		actWin = GameObject.FindGameObjectsWithTag ("ActionWindow");
//		インデックスは実行のたびに順不同になるんだって！！
//		transform.SetSiblingIndex();とかで順番をつかまえるらしい
//		Debug.Log (actWin[0].name + " 要素0番、" + actWin[1].name + " 要素1番、" + actWin[2].name + " 要素2番、" + actWin[3].name + " 要素3番、");

		fightMenu = gameObject.transform.FindChild ("FightMenu").GetComponent<Image> ();
		itemMenu = gameObject.transform.FindChild ("ItemMenu").GetComponent<Image> ();
		magicMenu = gameObject.transform.FindChild ("MagicMenu").GetComponent<Image> ();
		runawayMenu = gameObject.transform.FindChild ("RunawayMenu").GetComponent<Image> ();

		battlePlayer = GameObject.Find ("BattlePlayer").GetComponent<BattlePlayer> ();
//		enemy = GameObject.Find ("Enemy").GetComponent<Enemy> ();
		battleCon = GameObject.Find ("BattleController").GetComponent<BattleController> ();

		fightWinText = GameObject.Find ("FightWindow/Text").GetComponent<Text> ();
		fightWin = GameObject.Find ("FightWindow");
		hogehoge [0] = 1;
		hogehoge [1] = 2;
		hogehoge [2] = 3;
		hogehoge [3] = 4;

		inputMode = InputMode.NEUTRAL;
		fightWin.SetActive (false);
	}

	void Update () {
		
		if(Input.GetKeyDown(KeyCode.UpArrow) && inputMode == InputMode.NEUTRAL && battleCon.isStartBattle == true){
			ActionWinCountDown ();
		}

		if(Input.GetKeyDown(KeyCode.DownArrow) && inputMode == InputMode.NEUTRAL && battleCon.isStartBattle == true){
			ActionWinCountUp ();
		}

//		newしまくるよりはずっとましだけどあと一歩頑張りたい
		if(hogehoge[i] == 1){
			fightMenu.color = red;
			itemMenu.color = invisi;
			magicMenu.color = invisi;
			runawayMenu.color = invisi;
		}

		if(hogehoge[i] == 2){
			fightMenu.color = invisi;
			itemMenu.color = red;
			magicMenu.color = invisi;
			runawayMenu.color = invisi;
		}

		if(hogehoge[i] == 3){
			fightMenu.color = invisi;
			itemMenu.color = invisi;
			magicMenu.color = red;
			runawayMenu.color = invisi;
		}

		if(hogehoge[i] == 4){
			fightMenu.color = invisi;
			itemMenu.color = invisi;
			magicMenu.color = invisi;
			runawayMenu.color = red;
		}

		//『たたかう』選択時にスペースキー入力
		if (hogehoge [i] == 1 && Input.GetKeyDown (KeyCode.Space) && battleCon.isStartBattle == true 
			&& inputMode == InputMode.NEUTRAL) {
			//ここでリストにAddする
			//ListにAddする場合、タイミングが重要
			//Addしてから並び替えるより、先に並び替えてからAddするほうがよい
			actionPriority.Add(battlePlayer); 
			inputMode = InputMode.ACTIVE;
		}

		if(Input.GetKeyUp(KeyCode.Space) && battleCon.isStartBattle == true && inputMode == InputMode.ACTIVE){
			fightWinText.text = "";
			fightWin.SetActive (false);
			inputMode = InputMode.NEUTRAL;
			isPlayerDecision = true;
		}

//		actionPriorityに格納したクラスの実体を優先度順に呼び出す-----------------------
//		かつ、キーが押されてから順番に処理を実行する
		if(Input.GetKeyDown(KeyCode.E) && (current < actionPriority.Count)){
			if(actionPriority[current] is BattlePlayer){
				Debug.Log ("プレイヤーの攻撃");
			}

			if(actionPriority[current] is Enemy){
				Debug.Log ("モンスターの攻撃");
			}

			if(current <= actionPriority.Count){
				current++;
			}
		}
//		-------------------------------------------------------------------------------
	}
		
	void ActionWinCountUp(){
		i++;

		if(i > 3){
			i = 0;
		}
	}

	void ActionWinCountDown(){
		i--;

		if(i < 0){
			i = 3;
		}
	}
}
