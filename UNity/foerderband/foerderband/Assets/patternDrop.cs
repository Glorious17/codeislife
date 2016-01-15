﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class patternDrop : MonoBehaviour {

	public GameObject goodCup;
	public GameObject badCup;
	private GameObject go;
    public int maxCups = 16;
	public int level = 4;
	public float gridWidth = 0f;
	private int counter = 0;

	public int gridMin = 0;
	public int gridMax = 5;

	float xPos = 0F;
	float yPos = 5F;
	float zPos = 0F;
	float faktor = 4F;
	List<GameObject> pattern = new List<GameObject>();
	// Use this for initialization
	void Start () {
		spawnPattern ();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyUp("space")){
			deletePattern();
			if(level < maxCups){
				level++;
			}
			else{
				faktor = Random.Range (2F,5.0F);
				Debug.Log (faktor);
			}
			spawnPattern();
		}

		if (Input.GetKeyDown ("c")) {
            --level;
		}
	}

	void spawnPattern(){

		while(counter < level) {
			xPos = Random.Range(gridMin,gridMax) * gridWidth;
			zPos = Random.Range(gridMin,gridMax) * gridWidth;

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
	}

	void deletePattern(){

		counter = 0;

		foreach (GameObject p in pattern) {
			Destroy(p);
		}
		pattern.Clear();
	}

	bool isFreeSpace(){

		foreach (GameObject p in pattern) {

			if(xPos == p.transform.position.x && zPos == p.transform.position.z){
				return false;
			}
		
		}

		return true;
	}
}
