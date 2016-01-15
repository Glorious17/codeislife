using UnityEngine;
using System.Collections;

public class script_good : MonoBehaviour {
	public ball BallScript; 

	void OnTriggerEnter(Collider other){
		if (gameObject.name == "leftCollider" || gameObject.name == "rightCollider") {
			if (other.GetComponent<ball> ().quality_good)
				other.transform.Translate (-3, 2, 0);
		}else if(gameObject.name == "frontCollider" || gameObject.name == "backCollider"){
			if (other.GetComponent<ball> ().quality_good == false) {
				other.transform.Translate (0, 2, -2);
			}
		}
	}
}
