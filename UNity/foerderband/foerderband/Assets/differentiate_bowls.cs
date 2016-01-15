using UnityEngine;
using System.Collections;

public class differentiate_bowls : MonoBehaviour {
	void OnCollisionEnter(Collision col){
		print (col.collider.name);
	}
}
