using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
    }

    void OnGUI()
    {
        //if retry button is pressed load scene 0 the game
        GUI.contentColor = Color.cyan;
        if (GUI.Button(new Rect(Screen.width / 6, Screen.height / 2 - 10, 200, 100), "Start"))
        {
            Application.LoadLevel(1);

        }
        //and quit button
        if (GUI.Button(new Rect(Screen.width / 6, Screen.height / 2 + 110, 200, 100), "Quit"))
        {
            Application.Quit();
        }
    }

}
