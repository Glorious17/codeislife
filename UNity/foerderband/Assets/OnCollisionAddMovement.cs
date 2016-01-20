using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OnCollisionAddMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        GameObject go = col.gameObject;
        go.AddComponent<Treadmill>();
    }
}
