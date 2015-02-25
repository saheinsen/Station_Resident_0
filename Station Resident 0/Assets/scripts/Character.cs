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

	public KeyCode itemlock; //grabbign mechanic key
    public int playerhealth; //player health variable


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//jeptack lateral movement
		if (Input.GetKeyDown(boostup)) 
		{
			rigidbody2D.AddRelativeForce(Vector2.up * jetpackPowa);
		}
        if (Input.GetKeyDown(boostdown)) 
		{
			rigidbody2D.AddRelativeForce(-Vector2.up * jetpackPowa);
		}
        if (Input.GetKeyDown(boostright)) 
		{
			rigidbody2D.AddRelativeForce(Vector2.right * jetpackPowa);
		}
        if (Input.GetKeyDown(boostleft)) 
		{
			rigidbody2D.AddRelativeForce(-Vector2.right * jetpackPowa);
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
        
		RaycastHit2D blah = Physics2D.Raycast(gameObject.transform.position, Vector2.right, 1, layerMask);
		if (blah)
        {
            //Debug.Log("HERE");
            if (Input.GetKeyDown(itemlock) /*&& isGrabbed == false*/)
            {

                blah.collider.gameObject.transform.parent = gameObject.transform;
				blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true; 

            }
			else if (Input.GetKeyUp(itemlock) /*&& isGrabbed == true*/) 
			{

				blah.collider.gameObject.transform.parent = null;
				blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false; 

			}
			//= Physics2D.Raycast(transform.position, Vector2.right)
			//Physics2D.Raycast(transform.position, Vector2.right, 1, layerMask)
		


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

	
	}

