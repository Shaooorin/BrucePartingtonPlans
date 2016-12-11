using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FightWindow : MonoBehaviour {

	GameObject parent;
	RectTransform rect;
//	Text text;
	AudioManager audioM;

	bool hoge = false;

	int current = 0;

	void Awake(){
		rect = GetComponent<RectTransform> ();
//		text = GameObject.Find ("Message").GetComponent<Text> ();
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
		
	}
}
