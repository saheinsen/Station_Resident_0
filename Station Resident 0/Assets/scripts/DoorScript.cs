using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	public LayerMask doorlayer;
	public bool isopen;
	public AudioClip Movesound;
	AudioSource audioSource;
	// Use this for initialization
	void Start () 
	{
		audioSource = this.gameObject.AddComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	//if loop determining if player is within collider
	void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" && isopen == false) 
		{

			gameObject.transform.Translate(5, 0, 0);
			isopen = true;
			audioSource.PlayOneShot(Movesound);
		}
	}
	//loop to determine when player leaves the door
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" && isopen == true) 
		{
			gameObject.transform.Translate(-5, 0, 0);
			isopen = false;	 
			audioSource.PlayOneShot(Movesound);
		}
	}
}
