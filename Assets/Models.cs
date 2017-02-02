using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Models : MonoBehaviour {
	//Block Array
	public static string[] Variables = new string[]{"I","J","L","O","S","T","Z"};

	//Lookup
	public static void Lookup(string letter) {
		switch(letter) {
			case "I":
				I ();
				break;
			case "J":
				J ();	
				break;
			case "L":
				L ();	
				break;
			case "O":
				O ();	
				break;
			case "S":
				S ();	
				break;
			case "T":
				T ();	
				break;
			case "Z":
				Z ();	
				break;
		}
	}



	//API
	public static void I () {
		for (int i=0; i < 4; i++) {
			GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, i + (0.1F * i), 0);
		}
	}

	public static void J () {
		for (int i=0; i < 3; i++) {
			GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (i + (0.1F * i), 0, 0);
		}
		GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 1 + (0.1F * 1), 0);
	}

	public static void L () {
		for (int i=0; i < 3; i++) {
			GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (i + (0.1F * i), 0, 0);
		}
		GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 1 + (0.1F * 1), 0);
	}

	public static void O () {
		for (int i=0; i < 5; i++) {
			switch (i) {
				case 1:
					GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 0, 0);
					break;
				case 2:
					GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (1 + (0.1F * 1), 0, 0);
					break;
				case 3:
					GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 1 + (0.1F * 1), 0);
					break;
				case 4:
					GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (1 + (0.1F * 1), 1 + (0.1F * 1), 0);
					break;
			}
		}
	}

	public static void S () {
		for (int i=0; i < 5; i++) {
			switch (i) {
			case 1:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 0, 0);
				break;
			case 2:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (1 + (0.1F * 1), 1 + (0.1F * 1), 0);
				break;
			case 3:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (1 + (0.1F * 1), 0, 0);
				break;
			case 4:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (2 + (0.1F * 2), 1 + (0.1F * 1), 0);
				break;
			}
		}
	}

	public static void T () {
		for (int i=0; i < 3; i++) {
			GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (i + (0.1F * i), 0, 0);
		}
		GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (1 + (0.1F * 1), -1 + (-0.1F * 1), 0);
	}

	public static void Z () {
		for (int i=0; i < 5; i++) {
			switch (i) {
			case 1:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 0, 0);
				break;
			case 2:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (-1 + (-0.1F * 1), 1 + (0.1F * 1), 0);
				break;
			case 3:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (1 + (0.1F * 1), 0, 0);
				break;
			case 4:
				GameObject.CreatePrimitive (PrimitiveType.Cube).transform.position = new Vector3 (0, 1 + (0.1F * 1), 0);
				break;
			}
		}
	}
}
