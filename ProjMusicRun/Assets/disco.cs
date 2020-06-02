using UnityEngine;
using System.Collections;

public class disco : MonoBehaviour {
	public float velocidade; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,velocidade*Time.deltaTime);

		if(transform.position.z >= 30)

		{
			Destroy(gameObject);
		}

	}
}
