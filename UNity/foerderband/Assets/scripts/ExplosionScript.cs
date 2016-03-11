using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDrag(){
		Debug.Log ("HURRA");
		explosion ();
	}
	
	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.CompareTag("Good")){
			explosion();
		}
	}
	
	void explosion(){
		GetComponent<Renderer>().enabled = false;
		GameObject explosion = GameObject.Find("Bomb(Clone)");
		explosion.transform.localScale += new Vector3 (2f, 0f, 2f);
	}
}
