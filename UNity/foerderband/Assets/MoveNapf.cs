using UnityEngine;
using System.Collections;

public class MoveNapf : MonoBehaviour {

	private Rigidbody rb;
	private float z = 15f;
	public int speed = 5; 

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}


	void OnMouseDrag()
	{
		Vector3 v3 = Input.mousePosition;
		//v3.y = 0;
		v3.z = z;
		v3 = Camera.main.ScreenToWorldPoint(v3);

		rb.velocity = (v3 - gameObject.transform.position) * speed;
	}


}
