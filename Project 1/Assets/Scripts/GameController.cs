using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	static public int worldSupplyBronze;
	static public int worldSupplySilver;
	static public int worldSupplyGold;
    public int miningSpeed;
    int timeToMine;
	//I made cubes with scripts specific to their type, "cube" is bronze, "cube1" is silver, "cube2" is gold. I'm not sure how to rename them. The script also takes away a world supply count of its type of ore.
	public GameObject cubePrefab;
	public GameObject cube1Prefab;
	public GameObject cube2Prefab;
	GameObject currentCube;
	Vector3 cubePosition;

	// Use this for initialization, where the program/executable starts)
    void Start()
    {
		//these are variables, world suplly of ores and time between spawns.
		worldSupplyBronze = 0;
		worldSupplySilver = 0;
		worldSupplyGold = 0;
		miningSpeed = 3;
        timeToMine = 1;
    }
	// Update is called once per frame
    void Update()
    {
		//if time passed is greater than timeToMine (which is 1 second) something will happen.
		if (Time.time > timeToMine)
        {
			//Checks if 2 bronze, 2 silver, and 0 gold is true, if it is it spawns a gold ore, otherwise continues down the if else chain.
			if (worldSupplyBronze == 2 && worldSupplySilver == 2 && worldSupplyGold == 0) {
				//spawns the gold!
				//random.range and the numbers are stating that the cube will appear at x position between negative 5 and positive 5.
				//I extended the screen range(only works in fullscreen for some reason, bug? or webbuild specific?) so I could keep random spawns, which I think are more fun. Though I haven't figured out how to stop the rare cube overlap, I have minimized its occurrence.
				cubePosition = new Vector3 (Random.Range(-22, 23), Random.Range(-12, 13), 0); 
				currentCube = Instantiate (cube2Prefab, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.yellow;
				//adds 1 gold to the world supply.
				worldSupplyGold += 1;
			}  
			//Checks if the amount of bronze in the world is less than 4.
			else if (worldSupplyBronze < 4) {
				//the creation process of silver ore. 
				cubePosition = new Vector3 (Random.Range(-22, 23), Random.Range(-12, 13), 0); 
				currentCube = Instantiate (cubePrefab, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.red;
				//adds 1 bronze to the world supply.
				worldSupplyBronze += 1;
			}
			//Checks if the amount of bronze in the world is greater than 3 (so 4 or more)
			else if (worldSupplyBronze > 3)
            {
				//the creation process of silver ore.
				cubePosition = new Vector3 (Random.Range(-22, 23), Random.Range(-12, 13), 0); 
				currentCube = Instantiate (cube1Prefab, cubePosition, Quaternion.identity);
				currentCube.GetComponent<Renderer>().material.color = Color.white;
				//adds 1 silver to the world supply.
				worldSupplySilver += 1;
			}
			//Prints the exact amount(s) of ore that are spawned in the world.
			print("Bronze: " + worldSupplyBronze + " Silver: " + worldSupplySilver + " Gold: " + worldSupplyGold);

            timeToMine += miningSpeed;
        }
    }
    }