using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TextScroller : MonoBehaviour {

//	public string[] scenarios = new string[4];
	public List<string> scenarios = new List<string>();

	int currentLine = 0;
	public Text uiText;

	void Start () {
		TextUpdate ();
	}

	void Update () {
		if(currentLine < scenarios.Count && Input.GetKeyDown(KeyCode.Space)){
			TextUpdate ();
		}
	}

	void TextUpdate(){
		uiText.text = scenarios [currentLine];
		currentLine++;
	}
}