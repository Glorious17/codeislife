using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class patternDrop : MonoBehaviour {

 	//Script for repeadedly spawning Patterns over Time with increasing Difficulty


	public GameObject goodCup, badCup;
	public GameObject [] powerUp; //PowerUp Array
	public List<GameObject> pattern = new List<GameObject>(); //Gamobject of one Pattern will be saved in this list to delete them later on

	//Difficulty
	public int level = 3; 
	public int maxLevel = 18;
	private int counter = 0;

	//Measures of the pattern-grid
	private int gridWidth = 2;
	private int gridMin = 0;
	private int gridMax = 5;

	private GameObject go; //Filler object 
	public bool alreadyExists = false; 

	public float time = 0.0f;

	//Position of GameObject in the Pattern-Grid
	float xPos = 0F;
	float yPos = 5F;
	float zPos = 0F;
	float faktor = 4F; //Factor which decides the percentage of bad cups in one pattern

	void Start () {
		//First Spawn
		spawnPattern ();
	}

	void Update () {
		time += Time.deltaTime;
		if (time >= 7 && GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownActive == false) {
			deletePattern ();
			spawnPattern ();
		} else if (time >= 12 && GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownActive == true) {
			deletePattern();
			spawnPattern ();
		}
	}

	//Called in Update() or CupCounter.cs
	public void spawnPattern(){
		time = 0.0f;
		level++; //Difficulty increases with each spawn (max 18)

		//spawn one Pattern
		while(counter < level) {

			//Random Position in Grid 
			xPos = Random.Range(gridMin,gridMax) * gridWidth;
			zPos = Random.Range(gridMin,gridMax) * gridWidth;


			//Powerup spawn (randomized, only when time is an even number)
			if(isFreeSpace()){

				if(!alreadyExists && GUI.timeAnz > 0 && GUI.timeAnz%2==0){

					//PowerUp-Spawn, immer zu Zeitpunkten, die durch einen gewissen Faktor geteilt, den Rest 0 besitzen
					go = Instantiate(powerUp[(int)Random.Range(0f,powerUp.Length)], new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
					pattern.Add (go); //instantiiertes GameObject wird  der Liste hinzugefügt
					alreadyExists = true;
					counter++;
				}
			}

			//GoodCup/BadCup spawn
			if(isFreeSpace()){
				if(counter < Mathf.Round ((float)level/faktor)){
					go = Instantiate(badCup, new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;

				}else{
					go = Instantiate(goodCup, new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
				}
				pattern.Add(go);

				counter++;
			}
		}
		counter = 0;
	}

	//checks if Position in Grid is already occupied
	bool isFreeSpace(){

		foreach (GameObject p in pattern) {

			if(xPos == p.transform.position.x && zPos == p.transform.position.z){
				return false;
			}

		}

		return true;
	}

	//Deletes all GameObjects in pattern
	void deletePattern(){

		foreach (var p in pattern) {
			Destroy (p);
		}
		pattern.Clear ();

	}
}
