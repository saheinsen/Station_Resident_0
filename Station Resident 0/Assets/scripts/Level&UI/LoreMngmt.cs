using UnityEngine;
using System.Collections;

public class LoreMngmt : MonoBehaviour {
    
    //reference the script with the GUI format
    public LoreGUI Guimanager;
    
	//bools dictating whether or not the player has the lore item
	 public static bool Loreowned1 = false;
	 public static bool Loreowned2 = false;
	 public static bool Loreowned3 = false;
	 public static bool Loreowned4 = false;
	 public static bool Loreowned5 = false;
	 public static bool Loreowned6 = false;
	 public static bool Loreowned7 = false;
    
	//keys to access the lore arguments
	public KeyCode Loreaccess1;
	public KeyCode Loreaccess2;
	public KeyCode Loreaccess3;
	public KeyCode Loreaccess4;
	public KeyCode Loreaccess5;
	public KeyCode Loreaccess6;
	public KeyCode Loreaccess7;

	public Texture2D textureToDisplay;

	//audio
	AudioSource audioSource;
	public AudioClip itemGrab;
	
	
	public string Loretext;
	
	public bool isPaused = false;

	void Awake ()
	{
		//DontDestroyOnLoad(transform.gameObject);

	}

	// Use this for initialization
	void Start () 
    {
		audioSource = this.gameObject.AddComponent<AudioSource>();
        Guimanager = gameObject.GetComponent<LoreGUI>();
        Guimanager.enabled = false; //disable the GUI from the start of the script
	}
	
	// Update is called once per frame
	void Update () 	
	{

        Guimanager = gameObject.GetComponent<LoreGUI>();
        
		//accessing collected lore information and calling the GUI script to display it
	if (Input.GetKeyDown(Loreaccess1) && Loreowned1 == true) 
		{
            
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
                Guimanager.enabled = true;
				Loretext = ("If you ever wake up, know that you are not alone. \n I am trying to get us out of here. \n Look for the capsules I have left for you.");

                

			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
                Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess2) && Loreowned2 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("There are teleporters that can lead us back home. \n I am trying to repair them");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess3) && Loreowned3 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("I am sorry I did not wake you. \n I had more pressing matters to deal with. \n We are the only ones who survived.");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess4) && Loreowned4 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("I don't even know if you will wake up.");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess5) && Loreowned5 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("The worst part is the quiet. I cannot stand it. \n The sound of my breathing is the only thing keeping me sane. \n Have to be calm, Oxygen is running low");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess6) && Loreowned6 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("I am almost there. I hope to see you on the other side. \n Maybe I can shake your hand.");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess7) && Loreowned7 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("If you ever get this, you know that you are alone; I couldnt make it out. \n The capsules I left for you have the schematics for the last Teleporter. \n Good luck, Station Resident 0.");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}


	}
	
	//lore collision detection for each specific item
	void OnTriggerEnter2D(Collider2D col)
	{	
			if (col.gameObject.name == "Lore1") 
			{
			Loreowned1 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
			}
    
		if (col.gameObject.name == "Lore2") 
		{
			Loreowned2 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
		}

		if (col.gameObject.name == "Lore3") 
		{
			Loreowned3 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
		}

		if (col.gameObject.name == "Lore4") 
		{
			Loreowned4 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
		}

		if (col.gameObject.name == "Lore5") 
		{
			Loreowned5 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
		}	

		if (col.gameObject.name == "Lore6") 
		{
			Loreowned6 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
		}	

		if (col.gameObject.name == "Lore7") 
		{
			Loreowned7 = true;
			Destroy(col.gameObject);
			audioSource.PlayOneShot(itemGrab);
		}	


	}

    //Gui system that will display items for each peice of Lore the player collects
	void OnGUI()
	{
		if (Loreowned1 == true) 
		{
			GUI.Label(new Rect (10, 40, 50, 50), textureToDisplay);
		}

		if (Loreowned2 == true) 
		{
			GUI.Label(new Rect (70, 40, 50, 50), textureToDisplay);
		}

		if (Loreowned3 == true) 
		{
			GUI.Label(new Rect (130, 40, 50, 50), textureToDisplay);
		}

		if (Loreowned4 == true) 
		{
			GUI.Label(new Rect (190, 40, 50, 50), textureToDisplay);
		}

		
		if (Loreowned5 == true) 
		{
			GUI.Label(new Rect (250, 40, 50, 50), textureToDisplay);
		}

		if (Loreowned6 == true) 
		{
			GUI.Label(new Rect (310, 40, 50, 50), textureToDisplay);
		}

		if (Loreowned7 == true) 
		{
			GUI.Label(new Rect (370, 40, 50, 50), textureToDisplay);
		}
	}
}


