using UnityEngine;
using System.Collections;

public class CupCounter : MonoBehaviour {
    private int counter = 0;

    void OnTriggerEnter(Collider other)
    {
        counter++;
        Debug.Log(counter);
        Destroy(other.gameObject);
        if (GameObject.Find("Plane").GetComponent<patternDrop>().level == counter)
        {
            counter = 0;
            GameObject.Find("Plane").GetComponent<patternDrop>().pattern.Clear();
            GameObject.Find("Plane").GetComponent<patternDrop>().spawnPattern();
        }
    }
}
