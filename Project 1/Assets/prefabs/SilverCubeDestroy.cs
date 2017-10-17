using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilverCubeDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//When the mouse goes down
	}	void OnMouseDown () { 
		//removes this specific cube
		Destroy (gameObject);
		// worldSupplySilver goes down 1, will be reflected in the console.
		GameController.worldSupplySilver -= 1;
		// silverPointts goes up 10
		GameController.silverPoints += 10;
	}
}