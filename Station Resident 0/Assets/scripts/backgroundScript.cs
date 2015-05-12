using UnityEngine;
using System.Collections;

public class backgroundScript : MonoBehaviour {
	

	public GameObject player;
	Vector3 temp;


	
	void Update () 
	{
        //allows backgound to follow character movement but ignore thier rotation
		temp = player.transform.position;

		temp.x = player.transform.position.x;
		temp.y = player.transform.position.y;
		temp.z = gameObject.transform.position.z;

		gameObject.transform.position = temp;

	
	}
}
