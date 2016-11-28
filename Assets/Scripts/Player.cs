using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
	
	public float dash = 0.5f;
	public float speed = 5f;
	Rigidbody2D rb2d;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.RightArrow)){
			rb2d.AddForce (Vector2.right * dash,ForceMode2D.Impulse);
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow)){
			rb2d.AddForce (Vector2.left * dash,ForceMode2D.Impulse);
		}
	}

	void OnTriggerStay2D(Collider2D col){

		if(col.gameObject.tag == "Enemy" && Input.GetKeyDown(KeyCode.Space)){
			colEnemy = col.gameObject.name;
			SceneManager.LoadScene ("Battle_Scene");
		}
	}
	public static string colEnemy;

//	private void BombAttack(){
//		Collider[] targets = Physics.OverlapSphere (transform.position,50f);
//		foreach(Collider col in targets){
//			Enemy enemyInsta = col.gameObject;
//			enemyInsta = GetComponents<Enemy> ();
//			enemyInsta.enemyHp -= this.damage;
//		}
//	}
}
