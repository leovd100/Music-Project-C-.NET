using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {
	private float[] spectrum;
	private int i;
	private Vector3 scale;
	public float speed;
	public GameObject baseGm;
	// Use this for initialization
	void Start () {
		i = Random.Range(0,spectrum.Length);

	}
	
	// Update is called once per frame
	void Update () {
		spectrum = AudioListener.GetSpectrumData(512,0,FFTWindow.Hamming);
		scale = baseGm.transform.localScale;
		scale.y = spectrum[i] *7;
		baseGm.transform.localScale = scale;

		transform.Translate(0,0,speed*Time.deltaTime);

		if(baseGm.transform.localScale.y > 1)
		{
			baseGm.transform.localScale = new Vector3(baseGm.transform.localScale.x,1,baseGm.transform.localScale.z);
		}

		if (transform.position.z > 40){
			Destroy(gameObject);
		}

	}
}
