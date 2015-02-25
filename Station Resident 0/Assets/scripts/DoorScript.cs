using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	public LayerMask doorlayer;
	public bool isopen;
	// Use this for initialization
	void Start () {
	
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
		}
	}
	//loop to determine when player leaves the door
	void OnTriggerExit2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" && isopen == true) 
		{
			gameObject.transform.Translate(-5, 0, 0);
			isopen = false;	 
		}
	}
}
