using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BattleController : MonoBehaviour {

	Image curtainColor;
	public bool isStartBattle = false;

	void Start () {
		curtainColor = GameObject.Find ("Curtain").GetComponent<Image> ();
		curtainColor.enabled = true;
		StartCoroutine ("CurtainFadeOut");
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)){
			SceneManager.LoadScene ("Field_Scene");
		}
	}


	//画面のフェード----------------------------------------------------------------------
	public IEnumerator CurtainFadeOut(){
		for (int n = 9; n >= 0; n--){
			float alphaColor = n * 0.1f;
			curtainColor.color = new Color (0,0,0,alphaColor);
			yield return new WaitForSeconds (0.1f);
		}
		isStartBattle = true;
	}

	public IEnumerator CurtainFadeIn(){
		isStartBattle = false;
		for (int n = 0; n <= 10; n ++){
			float alphaColor = n / 10.0f;
			curtainColor.color = new Color (0,0,0,alphaColor);
			yield return new WaitForSeconds (0.1f);
		}
	}
}
