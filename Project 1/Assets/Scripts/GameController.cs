using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    int bronzePlayer;
    int silverPlayer;
    public int miningSpeed;
    public int bronzeSupply;
    int silverSupply;
    int timeToMine;
	float xPosition = 0f;


	//game object is type of variable, cubeprefab is a variable
	public GameObject cubePrefab;

	GameObject currentCube;
	Vector3 cubePosition;

	// Use this for initialization (does this count as the main method? main mehtod being where the program/executable starts)
    void Start()
    {
		//these are variables, world suplly of ores, time between mining, and players mined ores.
        bronzePlayer = 0;
        silverPlayer = 0;
        bronzeSupply = 3;
        silverSupply = 2;
		miningSpeed = 2;
        timeToMine = 1;

	
    }

	// Update is called once per frame (how often does the frame update? So this is like a world clock that keeps updating?)
    void Update()
    {
		// what is Time.time? timeToMine is something that is at 0.
        if (Time.time > timeToMine)
        {

            //if bronzeSupply is greater than zero,
            if (bronzeSupply > 0) {
			//than bronzeSupply goes down one,
                bronzeSupply -= 1;
			//and bronzePlayer goes up one.
                bronzePlayer += 1;

				//making cubes
				//random.range and the numbers are stating that the cube will appear at x position between negative 5 and positive 5.
				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5), 0); 
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.red;

			}

            //only mine bronze if we have 1 in supply

        else if (bronzeSupply == 0 && silverSupply > 0)
            {
                silverSupply -= 1;
                silverPlayer += 1;

				cubePosition = new Vector3 (Random.Range(-5, 5), Random.Range(-5, 5), 0); 
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.white;
            }

            /* bronzePlayer and silverPlayer are how much bronze or silver ore the player has.
             * So it's basically saying "You have mined X amount of Bronze and silver ore." where X is the players amount.
             * So the text will be "Bronze: (number)" and the number is the amount of ore of that type that the player has.
			 * tells the player how much ore they have mined.*/
            print("Bronze: " + bronzePlayer + "Silver: " + silverPlayer);

            timeToMine += miningSpeed;
        }

        //make sure we wait another miningspeed seconds before mining again.
        //update how many ore the player has
    }
    }
