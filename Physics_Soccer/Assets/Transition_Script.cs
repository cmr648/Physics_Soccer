using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class Transition_Script : MonoBehaviour {

	public Material Pixel_Material; // creating a public reference for the material we want to edit

	[Range(15,1000)] // creating a range
	public int Amount_Of_Pixels_In_Scene; // creating a range for eht amount of pixels we want in both rows and collums

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		Start_Scene ();


		Pixel_Material.SetFloat ("_PixelCollums", Amount_Of_Pixels_In_Scene); // setting our materials collums to the amount of pixels range

		Pixel_Material.SetFloat ("_PixelRows", Amount_Of_Pixels_In_Scene); // setting our materials collums to the amount of pixels range

	}

	void Start_Scene(){ // creating a void to start our scenne with





	}
}
