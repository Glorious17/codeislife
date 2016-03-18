using UnityEngine;
using System.Collections;

/*
* Handles the Bomb-Explosion
*/

public class ExplosionScript : MonoBehaviour {
		
	void OnMouseDrag(){
		explosion ();
	}
	
	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.CompareTag("Good")){
			explosion();
		}

		if (collision.gameObject.CompareTag ("Bad")) {
			explosion();
		}
	}
	
	void explosion(){
		//Object turns invisible and expands rapidly
		GetComponent<Renderer>().enabled = false;
		GameObject explosion = GameObject.Find("Bomb(Clone)");
		explosion.transform.localScale += new Vector3 (2f, 0f, 2f);
	}
}
