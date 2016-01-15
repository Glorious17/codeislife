using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ball : MonoBehaviour {
	public float movespeed = 10f;
	public bool quality_good = true;

	private Rigidbody rbody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float inputX = Input.GetAxis("Horizontal");
		float inputZ = Input.GetAxis ("Vertical");

		float moveX = inputX * movespeed * Time.deltaTime;
		float moveZ = inputZ * movespeed * Time.deltaTime;

		transform.Translate (moveX, 0, moveZ);
	}
}
