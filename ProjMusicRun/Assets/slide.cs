using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class slide : MonoBehaviour {
	//private float time_to_faded;
	private bool onclick;
//	private int porcentagemVolume;
//	public Scrollbar minhaBarra;
//	private int salvarVolume;
	public Color estudo;
	public Image imgr;

	public Color colortextoVol;
	public Text texVol;

	// Use this for initialization
	void Start () {
	//salvarVolume = porcentagemVolume;
		estudo = imgr.color;
		colortextoVol = texVol.color;
		estudo.a = 0;
		colortextoVol.a = 0;

	}
	
	// Update is called once per frame
	void Update () {
		//porcentagemVolume = Mathf.CeilToInt(minhaBarra.value *100);
		//Debug.Log(porcentagemVolume);
		//salvarVolume = porcentagemVolume;

		if(Input.GetKey("a"))
		{
			estudo.a -= Time.deltaTime*2;
		}

		if(Input.GetKey("d"))
		{
			estudo.a += Time.deltaTime*2;
		}



		if(onclick)
		{
			estudo.a += Time.deltaTime*2;
			colortextoVol.a += Time.deltaTime*2;
			colortextoVol.g -= Time.deltaTime*2;
			colortextoVol.r -= Time.deltaTime*2;
			colortextoVol.b -= Time.deltaTime*2;
		}

		if(!onclick)
		{
			estudo.a -= Time.deltaTime*2;
			colortextoVol.a -= Time.deltaTime*2;
			colortextoVol.g += Time.deltaTime*2;
			colortextoVol.r += Time.deltaTime*2;
			colortextoVol.b += Time.deltaTime*2;

		}



		if(estudo.a <= 0)
		{
			estudo.a = 0;
		}
		if(estudo.a >= 1){
			estudo.a = 1;
		}


		if(colortextoVol.a <= 0)
		{
			colortextoVol.a = 0;
		}
		if(colortextoVol.a >= 1){
			colortextoVol.a = 1;
		}


		if(colortextoVol.r <= 0)
		{
			colortextoVol.r = 0;
		}
		if(colortextoVol.r >= 1){
			colortextoVol.r = 1;
		}

		if(colortextoVol.g <= 0)
		{
			colortextoVol.g = 0;
		}
		if(colortextoVol.g >= 1){
			colortextoVol.g = 1;
		}


		if(colortextoVol.b <= 0)
		{
			colortextoVol.b = 0;
		}
		if(colortextoVol.b >= 1){
			colortextoVol.b = 1;
		}








		imgr.color = estudo;
		texVol.color = colortextoVol;
	}

	public void aoClicar()
	{

		onclick = true;

	}

	public void aoSoltar ()
	{
		onclick = false;
	}



}




