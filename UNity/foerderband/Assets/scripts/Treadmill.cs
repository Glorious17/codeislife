using UnityEngine;
using System.Collections;

public class Treadmill : MonoBehaviour {
    //Skript, was die Laufbandbewegung emuliert
    //jedes Objekt, was das Laufband berührt, bekommt dieses Skript zugewiesen
    private float publicSpeed = 0;

	void Start () {
		publicSpeed = GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().publicSpeed;
	}
	
	void Update () {
        publicSpeed = GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().publicSpeed;
        transform.position = new Vector3(transform.position.x + publicSpeed*Time.deltaTime, transform.position.y, transform.position.z);
	}

}
