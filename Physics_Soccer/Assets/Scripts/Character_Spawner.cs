using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Spawner : MonoBehaviour {

	GameObject[] Spawn_Points; // creating an array to hold our spawnpoints

	GameObject[] Players; // creating an array of transforms for our player

	public List<int> Spawn_Numbers; // creating a list of our spawn numbers

	public int Characters_To_Spawn; // creating a public int for characters to spawn

	public GameObject Player_Prefab; // creating a public player prefab to spawn;


	void Awake(){ // before start
		Create_Players(); // implementing our script to create players


	}

	// Use this for initialization
	void Start () {

		Spawn_Points = GameObject.FindGameObjectsWithTag ("Spawn_Point"); // assiging all of our spawn points
		Players = GameObject.FindGameObjectsWithTag("Player"); // assiging all of our player gameobjects
		Add_Spawn_Points(); // implementing our spawn points number
		Assign_Players(); // assigning our players to a random spawn poitn
	}
	
	// Update is called once per frame
	void Update () {


	}

	void Create_Players(){ // creating a void to instantiate our players into the world

		for (int i = 0; i < Characters_To_Spawn; i++) { // for however many characters we wish to spawn

			Instantiate (Player_Prefab, transform.position, Quaternion.identity); // instantiating a player object

		}


	}


	void Add_Spawn_Points(){ // adding our spawn points to our list

		for (int i = 0; i < Spawn_Points.Length; i++) { // for each item in spawn points
			Spawn_Numbers.Add(i); // add the object to spawn numbers

		}
	

	}

	void Assign_Players(){ // assigning a player to a random location

		for (int i = 0; i < Spawn_Numbers.Count; i++) { // for every item in spawn numbers that exists

			int Spawn_Position = Random.Range (0, Spawn_Numbers.Count); // creating a random spawn position point for where our character should spawn

			Players[i].transform.position = Spawn_Points [Spawn_Position].transform.position; // assigning our player to a to a random position
		

			Spawn_Numbers.Remove (Spawn_Numbers[Spawn_Position]); // remove that from possible spawn positios


		}
	}


}
