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

	//sets jetpack defaults
	void Start () 
	{
		
		Exhaust1.renderer.enabled = false;
		Exhaust1.particleSystem.enableEmission = false;
		Exhaust2.renderer.enabled = false;
		Exhaust2.particleSystem.enableEmission = false;
		Exhaust3.renderer.enabled = false;
		Exhaust3.particleSystem.enableEmission = false;
		Exhaust4.renderer.enabled = false;
		Exhaust4.particleSystem.enableEmission = false;
	}
	

	void Update () 
	{
        //individual appearence of each exhaust 

		if (Input.GetKeyDown(boostup)) 
		{

			Exhaust1.renderer.enabled = true;
			Exhaust1.particleSystem.enableEmission = true;

		}

		if (Input.GetKeyUp(boostup)) 
		{

			Exhaust1.renderer.enabled = false;
			Exhaust1.particleSystem.enableEmission = false;
			
		}

		if (Input.GetKeyDown(boostdown)) 
		{
			Exhaust2.renderer.enabled = true;
			Exhaust2.particleSystem.enableEmission = true;

		}

		if (Input.GetKeyUp(boostdown)) 
		{
			Exhaust2.renderer.enabled = false;
			Exhaust2.particleSystem.enableEmission = false;
			
		}

		if (Input.GetKeyDown(boostright)) 
		{
			Exhaust3.renderer.enabled = true;
			Exhaust3.particleSystem.enableEmission = true;
		}

		if (Input.GetKeyUp(boostright)) 
		{

			Exhaust3.renderer.enabled = false;	
			Exhaust3.particleSystem.enableEmission = false;
		}

		if (Input.GetKeyDown(boostleft)) 
		{
			Exhaust4.renderer.enabled = true;
			Exhaust4.particleSystem.enableEmission = true;
		}

		if (Input.GetKeyUp(boostleft)) 
		{

			Exhaust4.renderer.enabled = false;
			Exhaust4.particleSystem.enableEmission = false;
		}
		//handle player rotation similarly to lateral movement
		if (Input.GetKeyDown(rotateboostleft)) 
		{
			Exhaust3.renderer.enabled = true;
			Exhaust3.particleSystem.enableEmission = true;
		}

		if (Input.GetKeyUp(rotateboostleft)) 
		{
			Exhaust3.renderer.enabled = false;
			Exhaust3.particleSystem.enableEmission = false;
		}

		if (Input.GetKeyDown(rotateboostright)) 
		{
			Exhaust4.renderer.enabled = true;
			Exhaust4.particleSystem.enableEmission = true;
		}

		if (Input.GetKeyUp(rotateboostright)) 
		{
			Exhaust4.renderer.enabled = false;
			Exhaust4.particleSystem.enableEmission = false;
		}


		//spacebar to serve as brake for both rotation and lateral movement, called inertiamachine, renders all of the jetpack assets
		
				if (Input.GetKeyUp(inertiamachine))
				{
			Exhaust1.renderer.enabled = false;
			Exhaust1.particleSystem.enableEmission = false;
			Exhaust2.renderer.enabled = false;
			Exhaust2.particleSystem.enableEmission = false;
			Exhaust3.renderer.enabled = false;
			Exhaust3.particleSystem.enableEmission = false;
			Exhaust4.renderer.enabled = false;
			Exhaust4.particleSystem.enableEmission = false;
				}

		if (Input.GetKeyDown(inertiamachine)) 
		{
			Exhaust1.renderer.enabled = true;
			Exhaust1.particleSystem.enableEmission = true;
			Exhaust2.renderer.enabled = true;
			Exhaust2.particleSystem.enableEmission = true;
			Exhaust3.renderer.enabled = true;
			Exhaust3.particleSystem.enableEmission = true;
			Exhaust4.renderer.enabled = true;
			Exhaust4.particleSystem.enableEmission = true;
		}



		


	}
}
