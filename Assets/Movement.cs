﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public int v = 100;

	// Use this for initialization
	void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.A)) {
			transform.position += v * Time.deltaTime * Vector3.left;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.position += v * Time.deltaTime * Vector3.right;
		}

		transform.position += 5 * Time.deltaTime * Vector3.down;
		
	}
}