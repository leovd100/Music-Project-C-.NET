using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GM : MonoBehaviour {

	static public bool colisao;
	public Button restartButton;
	public Text textoGameOver;
	public AudioSource audio;
	private float timeToMusic = 3;
	private bool musicok;
	private bool DownMusinc = true;
	static public int contCube;
	private float armVol;
	public Slider volSlider;
	// Use this for initialization
	void Start () {
		restartButton.gameObject.SetActive(false);
		textoGameOver.text = "";
		spawn.isPlay = true;
		GMSound.stopCubes = false;
		colisao = false;
		armVol = audio.volume;
	}

	
	// Update is called once per frame
	void Update () {
		Debug.Log(contCube);
		timeToMusic -= Time.deltaTime;
		if (musicok == false){
			if (timeToMusic <= 0){
				timeToMusic = 0;
				audio.Play();
				musicok = true;
				textoGameOver.text = "";
			}
		}
		audio.volume = volSlider.value;
		if(colisao){
			restartButton.gameObject.SetActive(true);
			textoGameOver.text = "Game Over";
			spawn.isPlay = false;
			GMSound.stopCubes = true;
			MinVol();
			if (!DownMusinc) {
				audio.Stop();
			}
		}else{
			restartButton.gameObject.SetActive(false);
			textoGameOver.text = "";
			spawn.isPlay = true;
		}
	}
	public void Restart(string level){
		//Application.LoadLevel(level);
		if (contCube <= 0){
				musicok = false;
			    audio.volume = armVol;
				timeToMusic = 3;
				restartButton.gameObject.SetActive(false);
				textoGameOver.text = "";
				colisao = false;
				spawn.isPlay = true;
				GMSound.stopCubes = false;
				
		}
	}
	public void MinVol(){
		audio.volume -= Time.deltaTime*3;
		if (audio.volume <= 0){
			DownMusinc = false;
		}
	}
}
