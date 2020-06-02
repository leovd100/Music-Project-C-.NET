using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GC_music : MonoBehaviour {
	private AudioSource audio_clip;
	public AudioClip[] musica;
	public int valor;
	private int reset;
 	private bool ispause;
	public Text texto_pause;
	public Scrollbar barra;
	public Text valorporcent;
	private int valoresdevolume;
	public Text[] textomusica;
	private Button[] meubotao;
	public Text[] childbutton;
	public int id;
	public float temposegundos;
	public Button pause;
	public Sprite imagem_pause;
	public Sprite imagem_play;
//	public int randonByte;
	 	//public Slider scroll;
	// Use this for initialization
	void Start () {
		valor = 0;
		audio_clip = GetComponent<AudioSource>();
		audio_clip.clip = musica[valor];
		audio_clip.Play();
		reset = musica.Length;
		//randonByte = Random.Range(0,1024);
		//cilinder.i = randonByte;

		cilinder.i = Random.Range(0,cilinder.dataBatidas.Length);
	//	meubotao = GetComponent<Button>();


		for(int i = 0;i<=reset;i++)
		{
			textomusica[i].text = ""+musica[i].name;
			childbutton[i] = meubotao[i].GetComponentInChildren<Text>();


		//	if(childbutton == textomusica[i])
		//	{
		//		id = i;
		//	}

		}

	}
	
	// Update is called once per frame
	void Update () {

	//temposegundos = audio_clip.time/60;



		if(valor >= musica.Length)
		{
			valor = 0;
			audio_clip.clip = musica[valor];
			audio_clip.Play();
		}

		if(valor < 0)
		{  
			valor = musica.Length-1;
			audio_clip.clip = musica[valor];
			audio_clip.Play();

		}
		audio_clip.volume = barra.value;
		valoresdevolume = Mathf.CeilToInt(barra.value * 100);

		valorporcent.text = valoresdevolume + " %";


		if(!audio_clip.isPlaying && !ispause)
		{
			valor += 1;
		}





	}
	public void next()
	{
		if(ispause)
		{
			pause.image.sprite = imagem_pause;
			ispause = !ispause;
		}
		valor += 1;
		audio_clip.clip = musica[valor];
		audio_clip.Play();
		pause.image.sprite = imagem_pause;
	

	}

	public void back()
	{
		if(ispause)
		{
			pause.image.sprite = imagem_pause;
			ispause = !ispause;
		}
		valor -= 1;
	    audio_clip.clip = musica[valor];
	    audio_clip.Play();


	}


	public void pausa()
	{
		ispause = !ispause;

		if(ispause)
		{
			audio_clip.Pause();
			//texto_pause.text = "PLAY";
			pause.image.sprite = imagem_play;

		}

		if(!ispause){
			audio_clip.Play();
			//texto_pause.text = "PAUSE";
			pause.image.sprite = imagem_pause;

		}
			   
	}
	public void botao(int ident)
	{


		for(int i = 0;i<=reset;i++)
		{
			//textomusica[i].text = ""+musica[i].name;

			if(childbutton[i] == textomusica[i])
			{
				ident = i;
			}
			
		}

		audio_clip.clip = musica[ident];
		audio_clip.Play();

	}













}
