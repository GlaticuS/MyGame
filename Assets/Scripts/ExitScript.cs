﻿using UnityEngine;
using System.Collections;

public class ExitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Y)) 
		{
			Application.Quit ();
		} 
		else if (Input.GetKeyDown (KeyCode.N))
		{
			Application.LoadLevel("mainscene");
		}
	}
}
