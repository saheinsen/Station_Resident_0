using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    public LayerMask layerMask;
    public object interactable;
	
	public KeyCode boostup;
	public KeyCode boostdown;
	public KeyCode boostright;
	public KeyCode boostleft;
	public float jetpackPowa;
	public float jetpacksidePowa;
	public KeyCode inertiamachine;
	public KeyCode rotateboostleft;
	public KeyCode rotateboostright;

	public KeyCode itemlock;

	bool isGrabbed = false;

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
			//gameObject.rigidbody2D.fixedAngle = false;
			gameObject.rigidbody2D.angularDrag = 0f;
		}

		if (Input.GetKeyDown(inertiamachine)) 
		{
			gameObject.rigidbody2D.drag = 1f;
			//gameObject.rigidbody2D.fixedAngle = true;
			gameObject.rigidbody2D.angularDrag = 5f;
		}

        //Vector2 right = transform.TransformDirection(Vector2.right);
		RaycastHit2D blah = Physics2D.Raycast(gameObject.transform.position, Vector2.right, 1, layerMask);
		if (blah)
        {
            Debug.Log("HERE");
            if (Input.GetKeyDown(itemlock) /*&& isGrabbed == false*/)
            {

                blah.collider.gameObject.transform.parent = gameObject.transform;
				blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true; 
				isGrabbed = true;
            }
			else if (Input.GetKeyUp(itemlock) /*&& isGrabbed == true*/) 
			{

				blah.collider.gameObject.transform.parent = null;
				blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false; 
				isGrabbed = false;
			}
			//= Physics2D.Raycast(transform.position, Vector2.right)
			//Physics2D.Raycast(transform.position, Vector2.right, 1, layerMask)
		
		}

	
	}


	
	}

