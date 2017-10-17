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
	//when the mouse clicks down
	void OnMouseDown () { 
		//kill this thing!
		Destroy (gameObject);
		// the world supply for bronze goes down 1
		GameController.worldSupplyBronze -= 1;
		// bronzePoints goes up 1
		GameController.bronzePoints += 1;
}
}