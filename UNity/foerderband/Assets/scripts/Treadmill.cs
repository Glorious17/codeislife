using UnityEngine;
using System.Collections;

public class Treadmill : MonoBehaviour {
    //Skript, was die Laufbandbewegung emuliert
    //jedes Objekt, was das Laufband berührt, bekommt dieses Skript zugewiesen
    private float publicSpeed = 0;
	// Use this for initialization
	void Start () {
		publicSpeed = GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().publicSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        publicSpeed = GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().publicSpeed;
        transform.position = new Vector3(transform.position.x + publicSpeed*Time.deltaTime, transform.position.y, transform.position.z);
	}

}
