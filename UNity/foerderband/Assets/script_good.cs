using UnityEngine;
using System.Collections;

public class script_good : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (gameObject.name == "badCollider") {
			if (other.tag.Equals ("Bad")) {
				GameObject.Find ("Main Camera").GetComponent<GUI> ().score++;
			}else if (other.tag.Equals ("PowerUp")) {
				Debug.Log (other.gameObject.name);
				switch (other.gameObject.name) {
				case "OneUp(Clone)":
					Debug.Log ("britbritit");
					GameObject.Find ("Main Camera").GetComponent<GUI> ().leben++;
					break;
				case "SlowDown(Clone)":
					Debug.Log ("SLOOOOOOOWpoke");
					GameObject.Find ("Plane").GetComponent<Treadmill> ().slowDownStart = GameObject.Find ("Main Camera").GetComponent<GUI> ().timeAnz;
					GameObject.Find ("Plane").GetComponent<Treadmill> ().slowDownActive = true;
					break;
				case "Immortality(Clone)":
					Debug.Log ("gamedesigner können nichts");
					break;
				default:
					break;
				}

			}else
					GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
		}else if(gameObject.name == "goodCollider"){
			if (other.tag.Equals("Good"))
				GameObject.Find ("Main Camera").GetComponent<GUI> ().score++;
			else
				GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
		}
	}
}
