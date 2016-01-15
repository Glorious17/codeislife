using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

	public bool isPaused;
	public int leben = 3;
	public int score = 0;
	public float time = 0;
	public int timeAnz = 0;



	void start(){
		isPaused = false;

	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			score++;
		}

		time = time + Time.deltaTime;
		if (time >= 1.0f) {
			timeAnz += 1;
			time = 0;
		}
	}

	void OnGUI() {
		GUILayout.BeginArea (new Rect (Screen.width-105, 5, 100, 80));
		if (!isPaused)
		{
			if (GUILayout.Button("Pause"))
			{
				Time.timeScale = 0;
				isPaused = true;
			}
		}
		if (isPaused)
		{
			if (GUILayout.Button("Weiterspielen"))
			{
				Time.timeScale = 1;
				isPaused = false;
			}
		}
		GUILayout.Label ("Zeit: " + timeAnz);
		GUILayout.EndArea ();

		GUILayout.BeginArea (new Rect (5, 5, 100, 80));
		GUILayout.Label("Leben: " + leben);
		GUILayout.Label ("Score: " + score);
		GUILayout.EndArea ();
	}
}
