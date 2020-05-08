using UnityEngine;
using System.Collections;

public class camPlayer : MonoBehaviour {

	public bool left,center,right;
	private Vector3 posAbs;
	// Use this for initialization
	void Start () {
		center = true;
		posAbs = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(center){
			MoveCenter();
		}else{
			moveLR(left,right);
		}

		transform.position = Vector3.Lerp(transform.position,posAbs,1.2f*Time.deltaTime);
		
			

	}


	public void MoveCenter(){
		if (Input.GetKeyDown("a")){
			left = true;
			center = false;
			posAbs.x -= 4;
		}
		
		if (Input.GetKeyDown("d")){
			right = true;
			center = false;
			posAbs.x += 4;
			
		}
	}

	public void moveLR(bool left_t,bool right_t){
		if (left_t){
			if (Input.GetKeyDown("d")){
				center = true;
				left = false;
				posAbs.x += 4;
			}
		}
		if (right_t){
			if (Input.GetKeyDown("a")){
				center = true;
				right = false;
				posAbs.x -= 4;
			}
		}
	}
	
	
	
}