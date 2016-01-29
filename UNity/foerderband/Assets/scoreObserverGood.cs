using UnityEngine;
using System.Collections;

public class scoreObserverGood : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals("Good"))
			GameObject.Find ("Main Camera").GetComponent<GUI> ().score++;
		else
			GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
        Destroy(other.gameObject);
    }
}
