using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Arrow : MonoBehaviour {

	public float Rotate_Arrow_Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		if(Input.GetKey(KeyCode.RightArrow)){ // if the right arrow has been pressed
		transform.RotateAround (transform.parent.transform.position, Vector3.up, Time.deltaTime * Rotate_Arrow_Speed); // actually rotating our object
		}

		if(Input.GetKey(KeyCode.LeftArrow)){ // if the left arrow has been pressed
			transform.RotateAround (transform.parent.transform.position, Vector3.up, Time.deltaTime * -Rotate_Arrow_Speed); // actually rotating our object
		}



	}
}
