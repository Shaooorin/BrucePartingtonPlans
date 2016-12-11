using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ActionWindow : MonoBehaviour {

	GameObject parent;
	RectTransform rect;
	Text text;
	AudioManager audioM;
	GameMaster gameMaster;

	bool hoge = false;

	int current = 0;

	void Awake(){
		rect = GameObject.Find(this.name).GetComponent<RectTransform> ();
		text = GameObject.Find ("Message").GetComponent<Text> ();
		parent = GameObject.Find ("Canvas");
		audioM = GameObject.Find ("AudioManager").GetComponent<AudioManager> ();
		gameMaster = parent.GetComponent<GameMaster> ();
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
			text.text = gameMaster.intro[current];
		}

		if(Input.GetKeyDown(KeyCode.Space) && current != gameMaster.intro.Count){
			current++;
			audioM.Choice ();
			Debug.Log ("current : " + current);
			if(current != gameMaster.intro.Count){
				TextUpdate ();
			}
		}
		if(current == gameMaster.intro.Count && Input.GetKeyUp(KeyCode.Space)){
			Destroy(this.gameObject);
		}
	}
		
	void TextUpdate(){
		text.text = gameMaster.intro[current];
	}


}
