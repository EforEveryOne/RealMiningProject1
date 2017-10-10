using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
}

	void OnMouseDown () { 
		Destroy (gameObject);
		GameController.worldSupplyBronze -= 1;
}
}