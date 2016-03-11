using UnityEngine;
using System.Collections;

public class Start_GUI : MonoBehaviour {
	
	public bool isPaused;
	public int leben = 3;
	public int score = 0;
	public float time = 0;
	public int timeAnz = 0;
	
	
	
	void start(){	
	}
	
	void Update(){
	}
	
	void OnGUI() {
        int buttonWidth = 200, buttonHeight = 100;
        GUILayout.BeginArea(new Rect(Screen.width - Screen.width / 2 - buttonWidth / 2, Screen.height - Screen.height / 2 - buttonHeight / 2, buttonWidth, buttonHeight));
        if (GUILayout.Button("Start"))
		{
            Debug.Log("ufhsduifhsdfuidsfuih");
            Application.LoadLevel(1);
        }
		if (GUILayout.Button("Back to the Menu"))
		{
            Debug.Log("NADA!");
		}
		GUILayout.EndArea ();
	}
}
