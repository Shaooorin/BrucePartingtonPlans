using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleManager : MonoBehaviour {

	List<BattleObject> battleObj;

	// Use this for initialization
	void Start () {
		GameObject[] bObj = GameObject.FindGameObjectsWithTag ("BattleObject");
		foreach(GameObject go in bObj){
			Debug.Log (go.name);
			BattleObject bo = null;
			if(go is BattlePlayer){
				bo = go.GetComponent<BattlePlayer> ();
			}
			if(go is Enemy){
				bo = go.GetComponent<Enemy> ();	
				Debug.Log (bo);
			}
			battleObj.Add (bo);

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
