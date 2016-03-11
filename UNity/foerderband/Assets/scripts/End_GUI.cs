using UnityEngine;
using System.Collections;

public class End_GUI : MonoBehaviour {
		
	void start(){	
	}
	
	void Update(){
	}
	
	void OnGUI() {
        int buttonWidth = 200, buttonHeight = 100;
		GUILayout.BeginArea (new Rect (Screen.width-Screen.width/2 - buttonWidth/2, Screen.height - Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight));
        int score = 99;//GetComponent<GUI>().score;
        GUILayout.Label("Score: " + score);

        if (GUILayout.Button("Back to the Menu"))
		{
            Application.LoadLevel(0);
            Debug.Log("NADA!");
		}
		GUILayout.EndArea ();
	}
}
