using UnityEngine;
using System.Collections;

public class Treadmill : MonoBehaviour {

    public float speed = 3.0f;
    public float deltaSpeed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
        transform.position = new Vector3(transform.position.x + speed*Time.deltaTime, transform.position.y, transform.position.z);

        if(GameObject.Find("Main Camera").GetComponent<GUI>().timeAnz % 10 == 0)
        {
            speed += deltaSpeed * Time.deltaTime;
        }
	}

}
