using UnityEngine;
using System.Collections;

public class scoreObserverBad : MonoBehaviour {

	void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Bad"))
        {
            GameObject.Find("Main Camera").GetComponent<GUI>().score++;
        }
        else if (other.tag.Equals("PowerUp"))
        {
            Debug.Log(other.gameObject.name);
            switch (other.gameObject.name)
            {
                case "OneUp(Clone)":
                    Debug.Log("britbritit");
                    GameObject.Find("Main Camera").GetComponent<GUI>().leben++;
                    break;
                case "SlowDown(Clone)":
                    Debug.Log("SLOOOOOOOWpoke");
                    GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().slowDownStart = GameObject.Find("Main Camera").GetComponent<GUI>().timeAnz;
                    GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().slowDownActive = true;
                    break;
                case "Immortality(Clone)":
                    Debug.Log("gamedesigner können nichts");
                    break;
                default:
                    break;
            }

        }
        else
            GameObject.Find("Main Camera").GetComponent<GUI>().leben--;
    }
}
