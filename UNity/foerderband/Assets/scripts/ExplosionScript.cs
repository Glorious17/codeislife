using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {

	/*
 	* Script for handeling the Bomb-Explosion
	 * */
		
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
