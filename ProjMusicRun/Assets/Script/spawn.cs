using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	private int sorteio;
	private float timeTospawn;
	private float[] dataBatidas;
	public float padrao;
	public GameObject[] bs;
	private int save,j;
	private float x;
	static public bool isPlay;
	// Use this for initialization
	void Start () {

		isPlay = true;
		j = Random.Range(0,2);
		timeTospawn = padrao;

	}
	
	// Update is called once per frame
	void Update () {

	if(isPlay){

		dataBatidas = AudioListener.GetSpectrumData(512,0,FFTWindow.Blackman);
			
			//transform.localScale = new Vector3(0,dataBatidas[sorteio] * 14,0);
		x = dataBatidas[sorteio] * 18;

		timeTospawn -= Time.deltaTime;
		if (timeTospawn <= 0)
		{
			timeTospawn = 0;

		}
			
	
			switch(sorteio){
				case 0:
				if ((timeTospawn == 0) && (x > 0.21f) ){
					blocoDeInstancia(0,bs[j],padrao);
					j = Random.Range(0,2);
					}
				break;
					
				case 1:
				if (timeTospawn == 0 && (x > 0.21f)){
					blocoDeInstancia(4,bs[j],padrao);
					j = Random.Range(0,2);
					}
					break;
				case 2:
				if (timeTospawn == 0 && (x > 0.21f) ){
					blocoDeInstancia(-4,bs[j],padrao);
					j = Random.Range(0,2);
					}

					break;
				

				}
		}
	
	}


public void blocoDeInstancia (int q,GameObject obj,float tempo){
		transform.position = new Vector3(q,transform.position.y,transform.position.z);
		save = sorteio;

		sorteio = Random.Range(0,3);

		if (sorteio == save){
			sorteio = Random.Range(0,3);

			}
		if(sorteio != save){
					Instantiate(obj,transform.position,transform.rotation);
					timeTospawn = tempo;
			}

	
	}





}
