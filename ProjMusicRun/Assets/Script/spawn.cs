using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	private int sorteio;
	private float timeTospawn;

	public float padrao;
	public GameObject bs;
	private int save;

	static public bool isPlay;
	// Use this for initialization
	void Start () {

		isPlay = true;
		timeTospawn = padrao;

	}
	
	// Update is called once per frame
	void Update () {

	if(isPlay){
		timeTospawn -= Time.deltaTime;
		if (timeTospawn <= 0)
		{
			timeTospawn = 0;

		}
			
	
			switch(sorteio){
				case 0:
				if (timeTospawn == 0){
					blocoDeInstancia(0,bs,padrao);
					
					}
				break;
					
				case 1:
				if (timeTospawn == 0){
					blocoDeInstancia(4,bs,padrao);

					}
					break;
				case 2:
				if (timeTospawn == 0){
					blocoDeInstancia(-4,bs,padrao);

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
