using UnityEngine;
using System.Collections;

/*
 * Process Objects that pass the GoodCollider
 */

public class scoreObserverGood : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("Good"))
			GUI.score++;
		else if(other.tag.Equals("Bad"))
			GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
	}
}
