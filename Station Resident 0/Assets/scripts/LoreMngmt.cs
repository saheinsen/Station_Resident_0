using UnityEngine;
using System.Collections;

public class LoreMngmt : MonoBehaviour {
    
    //reference the script with the GUI format
    public LoreGUI Guimanager;
    
	//bools dictating whether or not the player has the lore item
	private static bool Loreowned1 = false;
	private bool Loreowned2 = false;
	private bool Loreowned3 = false;
	private bool Loreowned4 = false;
	private bool Loreowned5 = false;
	private bool Loreowned6 = false;
	private bool Loreowned7 = false;
	private bool Loreowned8 = false;
	private bool Loreowned9 = false;
    
	//keys to access the lore arguments
	public KeyCode Loreaccess1;
	public KeyCode Loreaccess2;
	public KeyCode Loreaccess3;
	public KeyCode Loreaccess4;
	public KeyCode Loreaccess5;
	public KeyCode Loreaccess6;
	public KeyCode Loreaccess7;
	public KeyCode Loreaccess8;
	public KeyCode Loreaccess9;
	
	
	
	
	public string Loretext;
	
	public bool isPaused = false;

	void Awake ()
	{
		//DontDestroyOnLoad(transform.gameObject);

	}

	// Use this for initialization
	void Start () 
    {
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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");

                

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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
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
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess8) && Loreowned8 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
			}
			else if (isPaused == true) 
			{
				isPaused = false;
				Time.timeScale = 1.0f;
				Guimanager.enabled = false;
				Loretext = ("");
			}
		}

		if (Input.GetKeyDown(Loreaccess9) && Loreowned9 == true) 
		{
			
			if (isPaused == false) 
			{
				isPaused = true;
				Time.timeScale = 0.0f;
				Guimanager.enabled = true;
				Loretext = ("LORE MOTHERFOCKA! DO YOU READ IT?");
				
				
				
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
	
	//lore collision detection
	void OnTriggerEnter2D(Collider2D col)
	{	
			if (col.gameObject.name == "Lore1") 
			{
			Loreowned1 = true;
			Destroy(col.gameObject);
			}
    
		if (col.gameObject.name == "Lore2") 
		{
			Loreowned2 = true;
			Destroy(col.gameObject);
		}

		if (col.gameObject.name == "Lore3") 
		{
			Loreowned3 = true;
			Destroy(col.gameObject);
		}

		if (col.gameObject.name == "Lore4") 
		{
			Loreowned4 = true;
			Destroy(col.gameObject);
		}

		if (col.gameObject.name == "Lore5") 
		{
			Loreowned5 = true;
			Destroy(col.gameObject);
		}	

		if (col.gameObject.name == "Lore6") 
		{
			Loreowned6 = true;
			Destroy(col.gameObject);
		}	

		if (col.gameObject.name == "Lore7") 
		{
			Loreowned7 = true;
			Destroy(col.gameObject);
		}	

		if (col.gameObject.name == "Lore8") 
		{
			Loreowned8 = true;
			Destroy(col.gameObject);
		}	

		if (col.gameObject.name == "Lore9") 
		{
			Loreowned9 = true;
			Destroy(col.gameObject);
		}
	}
}


