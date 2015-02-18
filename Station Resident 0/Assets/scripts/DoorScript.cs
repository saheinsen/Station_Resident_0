using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour {

	public LayerMask doorlayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit2D doorcheck = Physics2D.Raycast(gameObject.transform.position, -Vector2.right, 10, doorlayer);
		if (doorcheck.collider.gameObject.name == "Player")
		{
			Debug.Log("HERE");
			transform.Translate(0, +5, 0);
		}
	}
}
