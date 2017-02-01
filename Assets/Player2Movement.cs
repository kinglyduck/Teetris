using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour {
	public int v = 10;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position += v * Time.deltaTime * Vector3.left;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position += v * Time.deltaTime * Vector3.right;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += v * Time.deltaTime * Vector3.up;
		}

	}
}
