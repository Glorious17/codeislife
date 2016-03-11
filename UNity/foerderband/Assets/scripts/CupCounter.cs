using UnityEngine;
using System.Collections;

public class CupCounter : MonoBehaviour {
	private int counter = 0;
	
	void OnTriggerEnter(Collider other)
	{
		counter++;
		Debug.Log(counter);
		Destroy(other.gameObject);
		if (GameObject.Find("Treadmill").GetComponent<patternDrop>().level == counter)
		{
			counter = 0;
			GameObject.Find("Treadmill").GetComponent<patternDrop>().pattern.Clear();
			GameObject.Find("Treadmill").GetComponent<patternDrop>().alreadyExists = false;
			GameObject.Find("Treadmill").GetComponent<patternDrop>().spawnPattern();
		}
	}
}
