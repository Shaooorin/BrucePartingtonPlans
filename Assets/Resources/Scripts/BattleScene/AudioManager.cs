using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	AudioSource[] audioS;

	public AudioClip auClip001;
	public AudioClip auClip002;
	public AudioClip auClip003;

	void Awake () {
		audioS = GetComponents<AudioSource> ();
		audioS [0].clip = auClip001;
		audioS [1].clip = auClip002;
		audioS [2].clip = auClip003;
	}

	void Update () {
		
	}

	public void Choice(){
		audioS [0].Play ();
	}

	public void PopUp(){
		audioS [1].Play ();
	}

	public void StartBGM(){
		audioS [2].Play ();
	}
}
