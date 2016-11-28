using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Sprites;
using UnityEngine.SceneManagement;

public class EnemyImageController : MonoBehaviour {

	Image img;
	Texture2D texture;
	Enemy enemy;

	void Start () {
		if(SceneManager.GetActiveScene().name == "Battle_Scene"){
			enemy = GameObject.Find ("Enemy").GetComponent<Enemy> ();
			EnemyImageInit(enemy.enemyTextureName);
		}
	}

	void Update () {
		//敵は、第二形態など、時間軸によってビジュアルが変化する可能性がある
	}

	public void EnemyImageInit(string enemyTextureNum){
		//エンカウントした敵の番号を受け取って、対応する画像に差し替える
		texture = Resources.Load(enemyTextureNum) as Texture2D;
		img = GameObject.Find("Enemy").GetComponent<Image>();
		img.sprite = Sprite.Create(texture,new Rect(0,0,texture.width,texture.height),Vector2.zero);
	}
}