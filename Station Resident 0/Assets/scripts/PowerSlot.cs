using UnityEngine;
using System.Collections;

public class PowerSlot : MonoBehaviour {

    public LockedDoor poweredDoor;
	public GameObject connectedDoor;

//grab locked door component
	void Start () 
    {
		poweredDoor = connectedDoor.GetComponent<LockedDoor>();


	}
	

	void Update () 
    {
    

      
          
	}
//trigger to determine if the player has the power box placed in the collider
	void OnTriggerStay2D (Collider2D key)
	{
		if (key.collider2D.gameObject.tag == "Blarg")
		{

			poweredDoor.isUnlocked = true;

		}
	}  

}
