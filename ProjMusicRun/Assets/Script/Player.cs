using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour {
	private bool left,center,right;
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
		}else if (!center){
			moveLR(left,right);
		}
		
		transform.position = Vector3.Lerp(transform.position,posAbs,3*Time.deltaTime);
		
		
		
		
	}

	public void OnTriggerEnter(Collider coll){
		if (coll.gameObject.tag == "cube"){
			GM.colisao = true;
		}
	}

	

	void MoveCenter(){
		if (Input.GetKeyDown("a")){
			left = true;
			center = false;
			posAbs.x += 4;
		}
		
		if (Input.GetKeyDown("d")){
			right = true;
			center = false;
			posAbs.x -= 4;
			
		}
	}

	void moveLR(bool left_t,bool right_t){
		if (left_t){
			if (Input.GetKeyDown("d")){
				center = true;
				left = false;
				posAbs.x -= 4;
			}
		}
		if (right_t){
			if (Input.GetKeyDown("a")){
				center = true;
				right = false;
				posAbs.x += 4;
			}
		}
	}


}
