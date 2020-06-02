using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class teste : MonoBehaviour {
	private float[] spectrum;
	private float Conta; 
	private int i;
	private float tempo;
	public bool trava;
	// Use this for initialization
	void Start () {
		i = Random.Range(0,1024);
		tempo = 4;
	}
	
	// Update is called once per frame
	void Update () {
		tempo -= Time.deltaTime;
	


		spectrum = AudioListener.GetSpectrumData(1024,0,FFTWindow.Hamming);
		Conta = (spectrum[i]*50)+0.2f;
		transform.localScale = new Vector3(1,Conta,1);



		if(transform.localScale.y > 2.25f) // trava de escala em Y
		{
			transform.localScale = new Vector3(1,1.85f,1);
		}


		if(transform.localScale.y < 0.4 && tempo <= 0 && trava == false) // verifica se a barra fica abaixo de 0.4 e se sim faz um novo sorteio de valor
		{
			tempo = 4;
			i = Random.Range(0,1024); // faz sorteio

		}
		if(transform.localScale.y >0.4 && tempo <= 0) // verifica se a barra sobe mais que 0.4 em Y e trava a condiçao de cima
		{
			tempo = 0;
			trava = true;
		}

			

}
}