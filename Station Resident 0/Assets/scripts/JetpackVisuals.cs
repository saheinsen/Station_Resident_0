using UnityEngine;
using System.Collections;

public class JetpackVisuals : MonoBehaviour {



	public GameObject Exhaust1;
	public GameObject Exhaust2;
	public GameObject Exhaust3;
	public GameObject Exhaust4;

//	private float timeStamp;


	public KeyCode boostup; //player upward movement key
	public KeyCode boostdown; //player downward movement key
	public KeyCode boostright; //player rightward movement key
	public KeyCode boostleft;  //player leftward movement key
	
	public KeyCode inertiamachine; //brake key
	public KeyCode rotateboostleft; // rotate left key
	public KeyCode rotateboostright; //rotate right key


//	private float JetpackCooldownInSeconds = 1.0f;

	// Use this for initialization
	void Start () 
	{
		
		Exhaust1.renderer.enabled = false;
		Exhaust2.renderer.enabled = false;
		Exhaust3.renderer.enabled = false;
		Exhaust4.renderer.enabled = false;
	}
	
	// Update is called once per frame
	void Update () 
	{


		if (Input.GetKeyDown(boostup)) 
		{

			Exhaust1.renderer.enabled = true;
//			timeStamp = Time.time + JetpackCooldownInSeconds;

		}

		if (Input.GetKeyUp(boostup)) 
		{

			Exhaust1.renderer.enabled = false;
			//			timeStamp = Time.time + JetpackCooldownInSeconds;
			
		}

		if (Input.GetKeyDown(boostdown)) 
		{
			Exhaust2.renderer.enabled = true;
			Exhaust2.particleSystem.Play();
//			timeStamp = Time.time + JetpackCooldownInSeconds;
		}

		if (Input.GetKeyUp(boostdown)) 
		{
			Exhaust2.renderer.enabled = false;
			//			timeStamp = Time.time + JetpackCooldownInSeconds;
			
		}

		if (Input.GetKeyDown(boostright)) 
		{
			Exhaust3.renderer.enabled = true;
		}

		if (Input.GetKeyUp(boostright)) 
		{

			Exhaust3.renderer.enabled = false;			
		}

		if (Input.GetKeyDown(boostleft)) 
		{
			Exhaust4.renderer.enabled = true;
		}

		if (Input.GetKeyUp(boostleft)) 
		{

			Exhaust4.renderer.enabled = false;
		}
		//handle player rotation similarly to lateral movement
		if (Input.GetKeyDown(rotateboostleft)) 
		{
			Exhaust3.renderer.enabled = true;
		}

		if (Input.GetKeyUp(rotateboostleft)) 
		{
			Exhaust3.renderer.enabled = false;
		}

		if (Input.GetKeyDown(rotateboostright)) 
		{
			Exhaust4.renderer.enabled = true;
		}

		if (Input.GetKeyUp(rotateboostright)) 
		{
			Exhaust4.renderer.enabled = false;
		}


		//spacebar to serve as brake for both rotation and lateral movement, called inertiamachine
		
				if (Input.GetKeyUp(inertiamachine))
				{
					
					Exhaust1.renderer.enabled = false;
					Exhaust2.renderer.enabled = false;
					Exhaust3.renderer.enabled = false;
					Exhaust4.renderer.enabled = false;
				}

		if (Input.GetKeyDown(inertiamachine)) 
		{
			Exhaust1.renderer.enabled = true;
			Exhaust2.renderer.enabled = true;
			Exhaust3.renderer.enabled = true;
			Exhaust4.renderer.enabled = true;
		}



		


	}
}
