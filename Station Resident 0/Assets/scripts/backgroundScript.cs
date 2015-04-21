using UnityEngine;
using System.Collections;

public class backgroundScript : MonoBehaviour {
	

	public GameObject player;
	Vector3 temp;



	
	
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		temp = player.transform.position;

		temp.x = player.transform.position.x;
		temp.y = player.transform.position.y;
		temp.z = gameObject.transform.position.z;

		gameObject.transform.position = temp;

	
	}
}
