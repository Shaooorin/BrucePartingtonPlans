using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Node : MonoBehaviour {

	[HideInInspector]
	public string skillName;

//	public string skillInfo{get,set};
	//プロパティはインスペクターに表示されない

	GameObject nameHolder;

	void Awake(){
		nameHolder = this.transform.GetChild (0).gameObject;
	}

	void Start(){
		nameHolder.GetComponent<Text> ().text = skillName;
	}
}
