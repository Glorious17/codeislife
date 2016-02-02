using UnityEngine;
using System.Collections;

public class Treadmill : MonoBehaviour {

    public float speed = 3.0f;
    public float deltaSpeed = 0.5f;
	public int slowDownStart = 0;
	public bool slowDownActive = false;

	private float publicSpeed;
	private float slowSpeed = 1f;
	private int slowDownDuration = 7;
	// Use this for initialization
	void Start () {
		publicSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position = new Vector3(transform.position.x + publicSpeed*Time.deltaTime, transform.position.y, transform.position.z);

		if (!slowDownActive && GameObject.Find ("Main Camera").GetComponent<GUI> ().timeAnz % 10 == 0) {
			speed += deltaSpeed * Time.deltaTime;
			publicSpeed = speed;
		} else if(slowDownActive){
			publicSpeed = slowSpeed;
		}

		if (slowDownStart + slowDownDuration >= GameObject.Find ("Main Camera").GetComponent<GUI> ().timeAnz)
			slowDownActive = false;
	}

}
