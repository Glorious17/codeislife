using UnityEngine;
using System.Collections;

public class End_GUI : MonoBehaviour {
	private int score;

	void start(){
	}
	
	void Update(){

	}


	void OnGUI() {
		score = GUI.score;
		score += GUI.timeAnz;
        int buttonWidth = 200, buttonHeight = 100;
		GUILayout.BeginArea (new Rect (Screen.width-Screen.width/2 - buttonWidth/2, Screen.height - Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight));
        GUILayout.Label("Score: " + score);

        if (GUILayout.Button("Back to the Menu"))
		{
            Application.LoadLevel(0);
			GUI.timeAnz =0;
			GUI.score = 0;
			score = 0;
		}
		GUILayout.EndArea ();
	}
}
