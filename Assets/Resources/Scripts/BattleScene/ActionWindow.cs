using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ActionWindow : GameMaster {

	GameObject fight;
	GameObject parent;
	RectTransform rect;
	Text text;

	AudioManager audioM;

	bool hoge = false;

	int current = 0;

	void Awake(){
		rect = GameObject.Find(this.name).GetComponent<RectTransform> ();
		text = GameObject.Find ("Message").GetComponent<Text> ();
		parent = GameObject.Find ("Canvas");
		audioM = GameObject.Find ("AudioManager").GetComponent<AudioManager> ();
	}

	void Start () {
		this.rect.SetParent(parent.transform);
		this.rect.SetAsLastSibling ();
		this.rect.offsetMax = new Vector2 (0,0);
		this.rect.offsetMin = new Vector2 (0,0);
	}

	void Update () {
		if(hoge == false){
			hoge = true;
			audioM.PopUp ();
			Debug.Log ("current : " + current);
			text.text = intro[current];
		}

		if(Input.GetKeyDown(KeyCode.Space) && current != intro.Count){
			current++;
			audioM.Choice ();
			Debug.Log ("current : " + current);
			if(current != intro.Count){
				TextUpdate ();
			}
		}
		if(current == intro.Count && Input.GetKeyUp(KeyCode.Space)){
			Destroy(this.gameObject);
		}
	}
		
	void TextUpdate(){
		text.text = intro[current];
	}
}
