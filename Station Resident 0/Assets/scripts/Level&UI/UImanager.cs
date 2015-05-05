using UnityEngine;
using System.Collections;

public class UImanager : MonoBehaviour {

    public string[] CreditsTextLines = new string[0];


    public GUISkin myGUISkin;
    public Texture2D Background;
	public Texture2D tutorialBackground;
    public Texture2D logo;

    private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);

	private Rect toutorialRect = new Rect ((Screen.width / 2) - 100, (Screen.height / 2) - 200, 100, 100);

    private string menuState;

    private string main = "main";
    private string options = "options";
    private string credits = "credits";
	private string levelSelect = "Level select";
	public string tutorialScreeen = "Tutorial Screen";

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

		if (menuState == tutorialScreeen && Background != null) 
		{
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), tutorialBackground); 
		}

        if (logo != null)
        {
            GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), logo);
        }

        GUI.skin = myGUISkin;

        //check UIstate
        if (menuState == main)
        {
            WindowRect = GUI.Window(0, WindowRect, menuFunc, "Station Resident 0");
        }

        if (menuState == options)
        {
            WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
        }

		if (menuState == levelSelect) 
		{
			WindowRect = GUI.Window(0, WindowRect, levelFunc, "Level Select");
		}

		if (menuState == tutorialScreeen)
		{
			WindowRect = GUI.Window(0, toutorialRect, tutorialFunc, "");
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
			menuState = tutorialScreeen;

        }


		if (GUILayout.Button("Level Select")) 
		{
			menuState = levelSelect;
		}

        if (GUILayout.Button("Options"))
        {
            menuState = options;
        }

	
        if (GUILayout.Button("Credits"))
        {
            menuState = credits;
        }
		
        if (GUILayout.Button("Back"))
        {
			Application.Quit();
           
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
	

	private void levelFunc(int id)
	{
		if (GUILayout.Button("Level One"))
		{
			Application.LoadLevel(1);
		}
		
		if (GUILayout.Button("Level Two"))
		{
			Application.LoadLevel(2);
		}
		
		if (GUILayout.Button("Level Three"))
		{
			Application.LoadLevel(3);
		}

		if (GUILayout.Button("Level Four"))
		{
			Application.LoadLevel(4);
		}
		if (GUILayout.Button("Back"))
		{
			menuState = main;
		}

	}

	private void tutorialFunc(int id)
	{
		if (GUILayout.Button("Continue"))
		{
			Application.LoadLevel(1);		
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
