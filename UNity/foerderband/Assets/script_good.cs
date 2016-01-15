using UnityEngine;
using System.Collections;

public class script_good : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (gameObject.name == "badCollider") {
			if (!other.tag.Equals ("Good"))
				GameObject.Find ("Main Camera").GetComponent<GUI> ().score++;
			else
				GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
		}else if(gameObject.name == "goodCollider"){
			if (other.tag.Equals("Good"))
				GameObject.Find ("Main Camera").GetComponent<GUI> ().score++;
			else
				GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
		}
	}
}
