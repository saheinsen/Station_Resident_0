using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public LayerMask layerMask;
    public object interactable;
	
	public KeyCode boostup; //player upward movement key
    public KeyCode boostdown; //player downward movement key
    public KeyCode boostright; //player rightward movement key
    public KeyCode boostleft;  //player leftward movement key
    public float jetpackPowa; //overall speed added to player on button press
	public float jetpacksidePowa; //player rotation force added on button press
	public KeyCode inertiamachine; //brake key
	public KeyCode rotateboostleft; // rotate left key
	public KeyCode rotateboostright; //rotate right key

	public LevelManagement lvlManager;
	public GameObject Endbox;

    public bool isGrabbed = false;

	public KeyCode itemlock; //grabbing mechanic key
    public int playerhealth; //player health variables


	public KeyCode pause;
	public bool anotherpaused = false;

	public pauseMenu Pauser;
	

	

	// Use this for initialization
	void Start () 
	{

		lvlManager = Endbox.GetComponent<LevelManagement>();
		Pauser = gameObject.GetComponent<pauseMenu>();
		Debug.Log("herro");
		Pauser.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {


		//pause menu functionality
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


		//jetpack lateral movement
		if (Input.GetKeyDown(boostup)) 
		{
			rigidbody2D.AddForce(transform.up * jetpackPowa);
		}
        if (Input.GetKeyDown(boostdown)) 
		{
			rigidbody2D.AddForce(-transform.up * jetpackPowa);
		}
        if (Input.GetKeyDown(boostright)) 
		{
			rigidbody2D.AddForce(transform.right * jetpackPowa);
		}
        if (Input.GetKeyDown(boostleft)) 
		{
			rigidbody2D.AddForce(-transform.right * jetpackPowa);
		}

		//handle player rotation
		if (Input.GetKey(rotateboostleft)) 
		{
			rigidbody2D.AddTorque(jetpacksidePowa);
		}
		if (Input.GetKey(rotateboostright)) 
		{
			rigidbody2D.AddTorque(-jetpacksidePowa);
		}

		//spacebar to serve as brake for both rotation and lateral movement, called inertiamachine
		if (Input.GetKeyUp(inertiamachine)) 
		{

			//rigidbody2D.velocity = Vector2.zero;
			gameObject.rigidbody2D.drag = 0f;
			//gameObject.rigidbody2D.fixedAngle = false;//
			gameObject.rigidbody2D.angularDrag = 0f;
		}

		if (Input.GetKeyDown(inertiamachine)) 
		{
			gameObject.rigidbody2D.drag = 1f;
			//gameObject.rigidbody2D.fixedAngle = true;//
			gameObject.rigidbody2D.angularDrag = 5f;
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
                }

                else if (isGrabbed == true)
                {
                    blah.collider.gameObject.transform.parent = null;
                    blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
                    isGrabbed = false;
                }
            }

		}

	
		//death mechanic
		if (playerhealth <= 0) 
		{
			Application.LoadLevel(lvlManager.currentLevel);
		}

	}

    //hazardous object and damage management
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Hazard")
        {
         playerhealth = playerhealth - 10;
		
        }

    }

    //Health GUI
       public void OnGUI()
    { 
        GUI.backgroundColor = Color.red;
        GUI.Button(new Rect(1100, 50, playerhealth, 50), "");
    }


}
	
	

