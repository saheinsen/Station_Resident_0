using UnityEngine;
using System.Collections;

public class EndingScript : MonoBehaviour {

	public string[] CreditsTextLines = new string[0];
	
	
	public GUISkin myGUISkin;
	public Texture2D Background;
	public Texture2D logo;
	
	private Rect WindowRect = new Rect((Screen.width / 2) - 200, Screen.height / 2, 400, 200);
	
	private string menuState;
	
	private string main1 = "main1";
	private string main2 = "main2";
	
	private string textToDisplay = "Credits" + "\n";
	//private float volume = 1.0f;
	
	public GameObject Character;
	
	public LoreMngmt loreManager;

	// Use this for initialization
	void Start () 
	{

		
		for (int i = 0; i < CreditsTextLines.Length; i++)
		{
			textToDisplay += CreditsTextLines[i] + "\n";
		}
		textToDisplay += "Press Esc To Go Back";

		loreManager = Character.GetComponent<LoreMngmt>();


		if (LoreMngmt.Loreowned1 == true && LoreMngmt.Loreowned2 == true && LoreMngmt.Loreowned3 == true && LoreMngmt.Loreowned4 == true && 
		    LoreMngmt.Loreowned5 == true && LoreMngmt.Loreowned6 == true && LoreMngmt.Loreowned7 == true) 
		{
			menuState = main2;	
		}
		else 
		{
			menuState = main1;
		}

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
		if (menuState == main1 || menuState == main2)
		{
			WindowRect = GUI.Window(0, WindowRect, menuFunc, "Station Resident 0");
		}
	
		
	}
	
	private void menuFunc (int id)
	{
		if (menuState == main1) 
		{
			GUILayout.Label("Station Resident 0 never figured out how to escape the facility that will soon be their tomb. They could only wait as they slowly wasted away in the depths of space.");
		}
		if (menuState == main2) 
		    {
			GUILayout.Label("Using the information drawn from the numerous notes left, Station Resident 0 peiced together the parts in the lab to build the last Teleporter. The one that would take them home");
			}

		
		if (GUILayout.Button("Return to Menu"))
		{
			Application.LoadLevel(0);
		}
		
		
	}
	

		

	
	// Update is called once per frame
	void Update () 
	{

		
	}
}