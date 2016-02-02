using UnityEngine;
using System.Collections;

public class TreadmillRegulator : MonoBehaviour {
    //da jedes Objekt die gleiche Geschwindigkeit haben sollte, beziehen alle Objekte (mit Treadmill als Komponente) ihre Geschwindigkeit aus diesem Skript
    private float speed = 3.0f;
    private float deltaSpeed = 0.5f;
    public int slowDownStart = 0;
    public bool slowDownActive = false;

    public float publicSpeed;
    private float slowSpeed = 1f;
    private int slowDownDuration = 7;

    // Use this for initialization
    void Start () {
        publicSpeed = speed;
	}
	
	// Update is called once per frame
	void Update () {

        if (!slowDownActive && GameObject.Find("Main Camera").GetComponent<GUI>().timeAnz % 10 == 0)
        {
            speed += deltaSpeed * Time.deltaTime;
            publicSpeed = speed;
        }
        else if (slowDownActive)
        {
            publicSpeed = slowSpeed;
        }
        if (slowDownStart + slowDownDuration >= GameObject.Find("Main Camera").GetComponent<GUI>().timeAnz)
            slowDownActive = false;
    }
}
