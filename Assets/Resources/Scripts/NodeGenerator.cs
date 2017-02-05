using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NodeGenerator : MonoBehaviour {

	GameMaster gm;

	public GameObject content;

	public GameObject node;

	void Awake(){
		gm = GameObject.Find("GameMaster").GetComponent<GameMaster> ();

		//"Content"がplayerOnBattlefieldの数だけ回る
		//すべてのUI要素にContentがプレイヤーの数だけつくられる
		//それぞれのウィンドウの"Viewport"以下の子要素(Transform t in Viewport.transform)、
		//つまりContentのそれぞれをforeachで回せる
		//これでContentの準備オッケー！

//		content = GameObject.Find ("SkillMenu/AbilityView/Viewport/Content");

		foreach(int ps in gm.playerOnBattlefield[0].playerSkill){
			GameObject nodes = Instantiate (node);
			nodes.transform.SetParent (content.transform,false);
			nodes.GetComponent<RectTransform> ().offsetMax = new Vector2 (0,0);
			nodes.GetComponent<RectTransform> ().offsetMin = new Vector2 (0,0);
			nodes.GetComponent<Node>().skillName = SkillDictionary.skillDic[ps][1];
		}
	}
}
