using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GM : MonoBehaviour {

	static public bool colisao;
	public Button restartButton;
	public Text textoGameOver;
	// Use this for initialization
	void Start () {
		restartButton.gameObject.SetActive(false);
		textoGameOver.text = "";
		spawn.isPlay = true;
		GMSound.stopCubes = false;
		colisao = false;
	}
	
	// Update is called once per frame
	void Update () {


		if(colisao){
			restartButton.gameObject.SetActive(true);
			textoGameOver.text = "Game Over";
			spawn.isPlay = false;
			GMSound.stopCubes = true;
		}else{
			restartButton.gameObject.SetActive(false);
			textoGameOver.text = "";
			spawn.isPlay = true;
		}
	}
	public void Restart(string level){
		Application.LoadLevel(level);
	}
}
