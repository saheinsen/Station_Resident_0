using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public LayerMask layerMask;
    public object interactable;

	public KeyCode boostup; //player upward movement key
    public KeyCode boostdown; //player downward movement key
    public KeyCode boostright; //player rightward movement key
    public KeyCode boostleft;  //player leftward movement key
   
	public KeyCode inertiamachine; //brake key
	public KeyCode rotateboostleft; // rotate left key
	public KeyCode rotateboostright; //rotate right key


	//Jetpack info
	public float jetpackPowa; //overall speed added to player on button press
	public float jetpacksidePowa; //player rotation force added on button press
	private float timeStamp;
	private float JetpackCooldownInSeconds = 0.5f;//cooldown added

	//level management
	public LevelManagement lvlManager;
	public GameObject Endbox;

    public bool isGrabbed = false;

	public KeyCode itemlock; //grabbing mechanic key
    public int playerhealth; //player health variables

	//audio
	AudioSource audioSource;
	public AudioClip jetpackClip;
	public AudioClip jetpackRotateClip;
	public AudioClip InertiaMachineClip;
	public AudioClip BGM;
	public AudioClip grabSound;


	//event audio
	
	public delegate void currentMusic(AudioSource source, AudioClip clip); //The Delegate
	public static event currentMusic normMusicEnabled; //The Event

	public AudioSource backgroundMusic;
	public AudioClip normSound;
	public AudioClip dangerSound;

	//pausing info
	public KeyCode pause;
	public pauseMenu Pauser;
	public bool anotherpaused = false;


	// Use this for initialization
	void Start () 
	{
		audioSource = this.gameObject.AddComponent<AudioSource>();

		lvlManager = Endbox.GetComponent<LevelManagement>();

		normMusicEnabled(backgroundMusic, normSound);

		Pauser = gameObject.GetComponent<pauseMenu>();
		Pauser.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


		//pausing functionality
		if (Input.GetKeyDown(pause) && anotherpaused == false) 
		{
			Time.timeScale = 0.0f;
			Pauser.enabled = true;
			anotherpaused = true;
			
		}
		
		else if (Input.GetKeyDown(pause) && anotherpaused == true) 
		{
			Time.timeScale = 1.0f;
			Pauser.enabled = false;
			anotherpaused = false;
			
		}

		//jetpack lateral movement with both movement and audio on a one second delay
		if (Input.GetKeyDown(boostup)&& timeStamp <=Time.time) 
		{
			rigidbody2D.AddForce(transform.up * jetpackPowa);
			audioSource.PlayOneShot(jetpackClip, 0.1f);
			timeStamp = Time.time + JetpackCooldownInSeconds;
		}
		if (Input.GetKeyDown(boostdown)&& timeStamp <=Time.time) 
		{
			rigidbody2D.AddForce(-transform.up * jetpackPowa);
			audioSource.PlayOneShot(jetpackClip, 0.1f);
			timeStamp = Time.time + JetpackCooldownInSeconds;
		}
		if (Input.GetKeyDown(boostright)&& timeStamp <=Time.time) 
		{
			rigidbody2D.AddForce(transform.right * jetpackPowa);
			audioSource.PlayOneShot(jetpackClip, 0.1f);
			timeStamp = Time.time + JetpackCooldownInSeconds;
		}
		if (Input.GetKeyDown(boostleft)&& timeStamp <=Time.time) 
		{
			rigidbody2D.AddForce(-transform.right * jetpackPowa);
			audioSource.PlayOneShot(jetpackClip, 0.1f);
			timeStamp = Time.time + JetpackCooldownInSeconds;
		}

		//handle player rotation similarly to lateral movement
		if (Input.GetKeyDown(rotateboostleft)&& timeStamp <=Time.time) 
		{
			rigidbody2D.AddTorque(jetpacksidePowa);
			audioSource.PlayOneShot(jetpackRotateClip);
		}
		if (Input.GetKeyDown(rotateboostright)&& timeStamp <=Time.time) 
		{
			rigidbody2D.AddTorque(-jetpacksidePowa);
			audioSource.PlayOneShot(jetpackRotateClip);
		}

		//spacebar to serve as brake for both rotation and lateral movement, called inertiamachine
		if (Input.GetKeyUp(inertiamachine)) 
		{


			gameObject.rigidbody2D.drag = 0f;
			gameObject.rigidbody2D.angularDrag = 0f;
		}

		if (Input.GetKeyDown(inertiamachine)) 
		{
			gameObject.rigidbody2D.drag = 1f;
			gameObject.rigidbody2D.angularDrag = 5f;
			audioSource.PlayOneShot(InertiaMachineClip);

		}


        //Player grabbing mechanic in detail, uses raycast to see if item is near, 
        //then loops to manage weather or not the item is grabbed
        
		RaycastHit2D blah = Physics2D.Raycast(gameObject.transform.position, Vector2.right, 5, layerMask);
		if (blah)
        {
           
            if (Input.GetKeyDown(itemlock))
            {
                
                if (isGrabbed == false)
                {
                    blah.transform.localRotation = gameObject.transform.localRotation;
                    blah.collider.gameObject.transform.parent = gameObject.transform;
                    blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                    isGrabbed = true;
					audioSource.PlayOneShot(grabSound);
                }

                else if (isGrabbed == true)
                {
                    blah.collider.gameObject.transform.parent = null;
                    blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                    isGrabbed = false;
					audioSource.PlayOneShot(grabSound);
                }
            }

		}



		//death mechanic resets level
		if (playerhealth <= 0) 
		{
			Application.LoadLevel(lvlManager.currentLevel);
		}

	}

    //hazardous object and damage management based on player colission with music change based on health number
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Hazard")
        {
         playerhealth = playerhealth - 10;
		
		
			if (playerhealth < 50) 
			{
				normMusicEnabled(backgroundMusic, dangerSound);

			}

        }



    }

    //Health value GUI
       public void OnGUI()
    { 
        GUI.backgroundColor = Color.red;
        GUI.Button(new Rect(1100, 50, playerhealth, 50), "");
    }


}
	
	

