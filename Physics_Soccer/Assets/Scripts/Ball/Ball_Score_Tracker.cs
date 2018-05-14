using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Score_Tracker : MonoBehaviour {

	GameObject Last_Object_Touched = null; // creating a gameobject reference for the last object touched


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

	void OnCollisionEnter(Collision col){ //checking to see if any collision was made with nay object
		
		if (col.gameObject.tag == "Player") { // if a player has touched the ball


			Last_Object_Touched = col.gameObject; // assignign the last obejct hit to our gameobject variable
		
		}


	
	}
}
