﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Important_Variables : MonoBehaviour {

    public static KeyCode Player_1_Launch_Key;
    public static KeyCode Player_2_Launch_Key;
    public static KeyCode Player_3_Launch_Key;
    public static KeyCode Player_4_Launch_Key;


    public static KeyCode Player_1_Right;
    public static KeyCode Player_2_Right;
    public static KeyCode Player_3_Right;
    public static KeyCode Player_4_Right;

    public static KeyCode Player_1_Left;
    public static KeyCode Player_2_Left;
    public static KeyCode Player_3_Left;
    public static KeyCode Player_4_Left;




    void Awake()
    {
        // setting the launch keys of our players
        Player_1_Launch_Key = KeyCode.Space;
        Player_2_Launch_Key = KeyCode.Q;
        Player_3_Launch_Key = KeyCode.W;
        Player_4_Launch_Key = KeyCode.E;



        Player_1_Left = KeyCode.LeftArrow;
        Player_1_Right = KeyCode.RightArrow;

        Player_2_Left = KeyCode.A;
        Player_2_Right = KeyCode.S;

        Player_3_Left = KeyCode.D;
        Player_3_Right = KeyCode.F;

        Player_4_Left = KeyCode.G;
        Player_4_Right = KeyCode.H;



    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        


	}
}