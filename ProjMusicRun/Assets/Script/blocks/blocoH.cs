using UnityEngine;
using System.Collections;

public class blocoH : MonoBehaviour {
	private float[] spectrum;
	private Vector3 scale;
	private int i ;
	public int speed;
	// Use this for initialization
	void Start () {
		i = Random.Range(0,spectrum.Length);

	}
	
	// Update is called once per frame
	void Update () {
		speed = Random.Range(25,50);
		spectrum = AudioListener.GetSpectrumData(512,0,FFTWindow.Hamming);
		scale = transform.localScale;
		scale.z = spectrum[i] *250;
		transform.localScale = scale;

		if(transform.localScale.z > 2)
		{
			transform.localScale = new Vector3(transform.localScale.x,transform.localScale.y,2);
		}

		transform.Translate(0,0,speed*Time.deltaTime);
		if (transform.position.z > 40){
			Destroy(gameObject);
		}


	}
}
