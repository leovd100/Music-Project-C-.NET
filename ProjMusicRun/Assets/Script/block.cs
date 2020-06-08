using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {
	private float[] spectrum; 
	private int i;
	private Vector3 scale; // pega a Escala X Y Z do meu objento bem como sua posicao em um ambiente 3D
	public float speed; // velocidade do objeto
	public GameObject baseGm; // Base do objeto que ira receber as batidas
	private bool msId;
	// Use this for initialization
	void Start () {
		i = Random.Range(0,spectrum.Length);

	}
	
	// Update is called once per frame
	void Update () {
		if (!msId){
			
			GM.contCube += 1;
			msId = true;
		}


		spectrum = AudioListener.GetSpectrumData(512,0,FFTWindow.Hamming); // Seta no vetor Spectrum 512 posicoes, essas posicoes serao utilizadas para 
		//cada batida da musica, sendo elas atualizadas a cada frame do computador.

		scale = baseGm.transform.localScale; // Atribui a variavel escala o tamanho do objeto em X Y e Z

		scale.y = spectrum[i] *10; // Acessa o eixo Y do Vector3 e atribui a ele uma batida multiplicada por 9, modificando assim o tamanho do objeto. 
		/*
			Os valores de batidas variam, mas geralmente vao de 0 ate 0.0009. Um cubo tem dimensao normal de 1 x 1
			0.0009 x 0.0009 ficaria muito pequeno.

		 */





		baseGm.transform.localScale = scale; // Pega o Objeto BaseGM , acessa o transform.localScale refenrente ao tamanho do objeto e atualiza o valor

		transform.Translate(0,0,speed*Time.deltaTime); // move o objeto para frente

		if(baseGm.transform.localScale.y > 3.5f) // cria uma trava, para o objeto .
		{
			baseGm.transform.localScale = new Vector3(baseGm.transform.localScale.x,2,baseGm.transform.localScale.z);
		}


		if (transform.position.z > 40){// se a posicao do objeto for maior qu e 40 no eixo Z, delete ele.
			GM.contCube -= 1;
			Destroy(gameObject);

		}

	}
}
