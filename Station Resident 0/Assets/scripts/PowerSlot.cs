using UnityEngine;
using System.Collections;

public class PowerSlot : MonoBehaviour {

    public LockedDoor poweredDoor;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
    poweredDoor = gameObject.GetComponent<LockedDoor>();

	RaycastHit2D blah = Physics2D.Raycast(gameObject.transform.position, -Vector2.right, 5);
    if (blah.collider.gameObject.tag == "interactables")
    {
        Debug.Log("HERE");
        poweredDoor.isUnlocked = true;
        blah.transform.localRotation = gameObject.transform.localRotation;
        blah.collider.gameObject.transform.parent = gameObject.transform;
        blah.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
    }
                
          
	}
}
