using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {

    public bool isPaused;
    public int leben = 3;
    public static int score;
    public float time = 0;
    public static int timeAnz = 0;

    public Texture2D lives;

    void start() {
        isPaused = false;
    }

    void Update() {
        time = time + Time.deltaTime;
        if (time >= 1.0f) {
            timeAnz += 1;
            time = 0;
        }
		
    }

    void OnGUI() {
        GUILayout.BeginArea(new Rect(Screen.width - 105, 5, 100, 80));
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

        if (leben <= 0)
        {
            Application.LoadLevel(2);
        }
        GUILayout.Label("Zeit: " + timeAnz);
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(5, 38, 100, 80));

        GUILayout.Label("Score: " + score);
        GUILayout.EndArea();

        drawLives();
    }

    private void drawLives()
    {
        GUILayout.BeginHorizontal();
        for (int i = 0; i < leben; i++)
        {
            GUILayout.Label(lives);
            
        }
        GUILayout.EndHorizontal();
        
    }
}
