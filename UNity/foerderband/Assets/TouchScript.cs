using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	private Rigidbody rb;
	private float z = 10f;
	public int speed = 50; 

	void Start()
	{   
		rb = GetComponent<Rigidbody> ();
        rb.freezeRotation = true;
	}


	void OnMouseDrag()
	{
		Vector3 v3 = Input.mousePosition;
		v3.z = z;
		//Debug.Log (v3.z);
		v3 = Camera.main.ScreenToWorldPoint(v3);

		rb.velocity = (v3 - gameObject.transform.position) * speed;
	}
		
}
