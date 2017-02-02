using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		string RandBlock = Models.Variables [(int)Random.Range (0, 6)];
		Models.Lookup (RandBlock);
	}
}