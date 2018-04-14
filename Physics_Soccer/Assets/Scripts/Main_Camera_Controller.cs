using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Camera_Controller : MonoBehaviour {

	GameObject[] Player_Gameobjects; // creating a holder to add all of the player gameobjects in the game



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Player_Gameobjects = GameObject.FindGameObjectsWithTag ("Player"); // assiging all the player gameobjects to our holder



		
	}




}

