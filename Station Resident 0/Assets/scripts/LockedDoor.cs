using UnityEngine;
using System.Collections;

public class LockedDoor : MonoBehaviour {

    public bool isopen;
    public bool isUnlocked;


    // Use this for initialization
    void Start()
    {
        isUnlocked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
<<<<<<< HEAD
    //if loop determining if player is within collider and if the door is unlocked
=======
    //if loop determining if player is within collider
>>>>>>> origin/master
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && isopen == false && isUnlocked == true)
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
<<<<<<< HEAD
        } 
=======
        }
>>>>>>> origin/master
    }
}

