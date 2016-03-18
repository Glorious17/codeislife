using UnityEngine;
using System.Collections;

public class TreadmillRegulator : MonoBehaviour {
	//da jedes Objekt die gleiche Geschwindigkeit haben sollte, beziehen alle Objekte (mit Treadmill als Komponente) ihre Geschwindigkeit aus diesem Skript
	private float speed = 3.0f;
	private float deltaSpeed = 0.5f;
	public float slowDownStart = 0f;
	public bool slowDownActive = false;
	
	public float publicSpeed;
	private float slowSpeed = 1f;
	public float slowDownDuration = 5;
	
	void Start () {
		if (slowDownActive) {
			publicSpeed = speed;
		} else {
			publicSpeed = slowSpeed;
		}
	}
	
	void Update () {

        //Speed increases every 10 seconds if slowdown is not active
		if (!slowDownActive && GUI.timeAnz % 10 == 0)
		{
			speed += deltaSpeed * Time.deltaTime;
			publicSpeed = speed;
		}
		else if (slowDownActive)
		{
			publicSpeed = slowSpeed;
			
		}

        //End of slowDown
		if (slowDownActive && slowDownStart + slowDownDuration <= GUI.timeAnz) {
			slowDownActive = false;
			publicSpeed = speed;
		}
	}
}
