using UnityEngine;
using System.Collections;

public class InvertScreen : MonoBehaviour 
{
	public GameObject descam;
	public GameObject falseposCam;
	public GameObject trueposCam;
	public GameObject mainCam;

	const int max = 50;
	float xpos;
	float yrot;

	public int i = max;

	void Start()
	{
		xpos = (mainCam.transform.position.x  - descam.transform.position.x ) / max;
		yrot = (mainCam.transform.localEulerAngles.y - descam.transform.localEulerAngles.y) / max;
	}

	void Update()
	{
		if (i < max) 
		{
			if(descam.Equals(falseposCam)) mainCam.transform.Translate(-xpos,0,0, Space.World);
			else mainCam.transform.Translate(xpos,0,0, Space.World);

			mainCam.transform.Rotate (0,yrot,0, Space.World);
			i++;

			if(i == max){
				if (descam.Equals(falseposCam)) {
					descam = trueposCam;
				} else {
					descam = falseposCam;
				}
			}
		}
	}
}
