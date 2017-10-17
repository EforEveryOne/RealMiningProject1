using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCubeDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//when the mouse clicks on this cube
	}	void OnMouseDown () { 
		//this cube is removed
		Destroy (gameObject);
		// the worldSupplyGold variable will go down 1
		GameController.worldSupplyGold -= 1;
		// the goldPoints will go up by 100! Which will be converted into the players total score!
		GameController.goldPoints += 100;
	}
}