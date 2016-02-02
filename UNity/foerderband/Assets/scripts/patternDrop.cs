using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class patternDrop : MonoBehaviour {

	public GameObject goodCup, badCup;
	public GameObject [] powerUp; //PowerUp Array
    public List<GameObject> pattern = new List<GameObject>(); //Liste in der die GGameObjecte des Musters abgespeichert werden, um sie wieder zu löschen

    public int level = 3;
    public int maxLevel = 18;
	private int gridWidth = 2;
    private int gridMin = 0;
    private int gridMax = 5;

    private GameObject go;
    private bool alreadyExists = false;
	private int counter = 0;

	float xPos = 0F;
	float yPos = 5F;
	float zPos = 0F;
	float faktor = 4F; //Faktor, um die Anzahl der schelchten Näpfe zu bestimmen
	
	// Use this for initialization
	void Start () {
		spawnPattern ();
	}
	
	// Update is called once per frame
    /*
	void Update () {

		if(Input.GetKeyUp("space")){
			deletePattern();
			if(level < maxLevel){
				level++;
			}
			else{
				faktor = Random.Range (2F,5.0F);
				Debug.Log (faktor);
			}
			spawnPattern();
		}

		if (Input.GetKeyDown ("s")) {
			Debug.Log(Mathf.Round(Random.Range(1,5)) * gridWidth);
		}
	}
    */

	public void spawnPattern(){
        ++level;
		while(counter < level) {
			xPos = Random.Range(gridMin,gridMax) * gridWidth;
			zPos = Random.Range(gridMin,gridMax) * gridWidth;

			if(isFreeSpace()){

				if(!alreadyExists && GameObject.Find ("Main Camera").GetComponent<GUI> ().timeAnz > 0 && GameObject.Find ("Main Camera").GetComponent<GUI> ().timeAnz%3==0){
                    //PowerUp-Spawn, immer zu Zeitpunkten, die durch einen gewissen Faktor geteilt, den Rest 0 besitzen
                    go = Instantiate(powerUp[(int)Random.Range(0f,2f)], new Vector3(xPos, yPos, zPos), Quaternion.identity) as GameObject;
					pattern.Add (go); //instantiiertes GameObject wird  der Liste hinzugefügt
					alreadyExists = true;
					counter++;
				}

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

	public void deletePattern(){

		counter = 0;

		foreach (GameObject p in pattern) {
			Destroy(p);
		}
		alreadyExists = false;
		pattern.Clear (); //Liste wird zurückgesetzt
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
