using UnityEngine;
using System.Collections;

public class UImanager : MonoBehaviour {

    public string[] CreditsTextLines = new string[0];


    public GUISkin myGUISkin;
    public Texture2D Background;
    public Texture2D logo;

    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);

    private string menuState;

    private string main = "main";
    private string options = "options";
    private string credits = "credits";

    private string textToDisplay = "Credits" + "\n";
    private float volume = 1.0f;

	// Use this for initialization
	void Start () 
    {
        menuState = main;

        for (int i = 0; i < CreditsTextLines.Length; i++)
        {
            textToDisplay += CreditsTextLines[i] + "\n";
        }
        textToDisplay += "Press Esc To Go Back";
	}
	

    private void OnGUI()
    {
        if (Background != null) //checks for null reference exception
        {
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), Background); //work directly with screen space
        }

        if (logo != null)
        {
            GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), logo);
        }

        GUI.skin = myGUISkin;

        //check UIstate
        if (menuState == main)
        {
            WindowRect = GUI.Window(0, WindowRect, menuFunc, "Main Menu");
        }

        if (menuState == options)
        {
            WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        }

        if (menuState == credits)
        {
            GUI.Box(new Rect(0, 0, Screen.width, Screen.height), textToDisplay);
        }

    }

    private void menuFunc (int id)
    {
        if (GUILayout.Button("Play Game"))
        {
            Application.LoadLevel("wrapper_ui");
        }

        if (GUILayout.Button("Options"))
        {
            menuState = options;
        }

        if (GUILayout.Button("Credits"))
        {
            menuState = credits;
        }

        if (GUILayout.Button("Quit Game"))
        {
            Application.Quit();
            Debug.Log("WOLOLOLOLOLOLOLOLO");
        }
    }

    private void optionsFunc(int id)
    {
        GUILayout.Box("Volume");
        volume = GUILayout.HorizontalSlider(volume, 0.0f, 1.0f);
        AudioListener.volume = volume;
        
        if (GUILayout.Button("Back"))
        {
            menuState = main;
        }
    }

	// Update is called once per frame
	void Update () 
    {

        if (menuState == credits && Input.GetKey(KeyCode.Escape))
        {
            menuState = main;
        }
	}
}
