using UnityEngine;
using System.Collections;

public class GMSound : MonoBehaviour {
	public GameObject[] repoObj;
	public GameObject[] targets;

	private float[] spectrum;
	private int i,j;
	private float timeToSpawn;

	static public bool stopCubes;
	// Use this for initialization
	void Start () {
		i = Random.Range(0,512);
		j = Random.Range(0,2);
	}
	
	// Update is called once per frame
	void Update () {
		if (!stopCubes){
		timeToSpawn -= Time.deltaTime;
		spectrum = AudioListener.GetSpectrumData(512,0,FFTWindow.Hamming);


		if (spectrum[i] *10 > 0.03f && timeToSpawn <= 0){
			Instantiate (repoObj[j],targets[0].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
			timeToSpawn = 0.3f;
		   }

		if (spectrum[i] *10> 0.01f && timeToSpawn <= 0){

			Instantiate (repoObj[j],targets[1].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
			timeToSpawn = 0.3f;
		}

		if (spectrum[i] *10> 0.18f && timeToSpawn <= 0){
	
			Instantiate (repoObj[j],targets[2].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
			timeToSpawn = 0.3f;
		}

		if (spectrum[i] *10> 0.009f && timeToSpawn <= 0){
		
			Instantiate (repoObj[j],targets[3].transform.position,targets[0].transform.rotation);
			j = Random.Range(0,2);
			timeToSpawn = 0.3f;

		}

		}









	}
}
