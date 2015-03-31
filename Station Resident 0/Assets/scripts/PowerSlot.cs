using UnityEngine;
using System.Collections;

public class PowerSlot : MonoBehaviour {

    public LockedDoor poweredDoor;
<<<<<<< HEAD
	public GameObject connectedDoor;
=======
>>>>>>> origin/master

	// Use this for initialization
	void Start () 
    {
<<<<<<< HEAD
		poweredDoor = connectedDoor.GetComponent<LockedDoor>();


=======
	
>>>>>>> origin/master
	}
	
	// Update is called once per frame
	void Update () 
    {
<<<<<<< HEAD
    

      
          
	}
//trigger to determine if the player has the power box placed in the collider
	void OnTriggerStay2D (Collider2D key)
	{
		if (key.collider2D.gameObject.tag == "Blarg")
		{

			poweredDoor.isUnlocked = true;

		}
	}  

=======
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
>>>>>>> origin/master
}
