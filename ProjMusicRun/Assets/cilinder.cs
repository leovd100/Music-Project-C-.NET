using UnityEngine;
using System.Collections;

public class cilinder : MonoBehaviour {
	static public float[] dataBatidas;
	static public int i;
	private int sorteio;
	public GameObject target;
	public bool A15;
	public bool A20;
	public bool A35;
	//public Light luz;
	private float curreentTime;
	private float myT;
	private float x;
	// Use this for initialization
	void Start () {
		//i = Random.Range(0,dataBatidas.Length);

		sorteio = Random.Range(0,dataBatidas.Length);
		curreentTime = 5;
		/*
		for (int b = 0; b < 5; b++)
		{

			myT = transform.localScale.y;

		}
		*/

	}
	
	// Update is called once per frame
	void Update () {
		//luz.intensity = 1.5f;
		dataBatidas = AudioListener.GetSpectrumData(512,0,FFTWindow.Blackman);

		//transform.localScale = new Vector3(0,dataBatidas[sorteio] * 14,0);

		//luz.intensity = 2 + (dataBatidas[i]*1200);
		/*
		if(transform.localScale.y > 0.15f)

		{
			
			Instantiate(target,transform.position,Quaternion.identity);
			luz.intensity = 4 + (dataBatidas[sorteio]*1600);
		}


		*/


		if(A15){
			x = dataBatidas[sorteio] * 16;
			if(x > 0.12f && x < 0.18f)
			{

				Instantiate(target,transform.position,Quaternion.identity);//Quaternion.identity);
				//luz.intensity = 5 + (dataBatidas[sorteio]*1400);

			}

		}

		if(A20){
			x = dataBatidas[sorteio] * 19;
			if(x > 0.22f && x < 0.38f)
			{

				Instantiate(target,transform.position,Quaternion.identity);
				//luz.intensity = 5 + (dataBatidas[sorteio]*1400);

			}
			
		}

		if(A35){
			x = dataBatidas[sorteio] * 30;
			if(x > 0.60f && x < 0.90f)
			{	//0.35
				
				Instantiate(target,transform.position,Quaternion.identity);
			//	luz.intensity = 5 + (dataBatidas[sorteio]*1400);

			}
			
		}



	}
}
