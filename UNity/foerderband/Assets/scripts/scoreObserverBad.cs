using UnityEngine;
using System.Collections;

public class scoreObserverBad : MonoBehaviour {

	public Camera mainCam;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals("Bad"))
		{
			GameObject.Find("Main Camera").GetComponent<GUI>().score++;
		}
		else if (other.tag.Equals("PowerUp"))
		{
			switch (other.gameObject.name)
			{
			case "OneUp(Clone)":
				if(GameObject.Find("Main Camera").GetComponent<GUI>().leben < 5)
					GameObject.Find("Main Camera").GetComponent<GUI>().leben++;
				break;
			case "SlowDown(Clone)":
				GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().slowDownStart = GameObject.Find("Main Camera").GetComponent<GUI>().timeAnz;
				GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().slowDownActive = true;
				break;
			case "Invert(Clone)":
				mainCam.GetComponent<InvertScreen> ().i = 0;
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownStart = GameObject.Find ("Main Camera").GetComponent<GUI> ().timeAnz;
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownDuration = 1.4f;
				GameObject.Find("Treadmill").GetComponent<TreadmillRegulator>().slowDownActive = true;

				break;
			default:
				break;
			}
			
		}
		else
			GameObject.Find("Main Camera").GetComponent<GUI>().leben--;
	}
}
