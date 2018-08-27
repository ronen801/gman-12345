﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.F))
			this.GetComponent<Light> ().enabled = true;
		if (Input.GetKey (KeyCode.G))
			this.GetComponent<Light> ().enabled = false;
	}
}
