using UnityEngine;
using System.Collections;

public class LockedDoor : MonoBehaviour {

    public bool isopen;
    public bool isUnlocked;
	public AudioClip Movesound;
	AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
		audioSource = this.gameObject.AddComponent<AudioSource>();
        isUnlocked = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //if loop determining if player is within collider and if the door is unlocked
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && isopen == false && isUnlocked == true)
        {
			audioSource.PlayOneShot(Movesound);
            gameObject.transform.Translate(5, 0, 0);
            isopen = true;
        }
    }
    //loop to determine when player leaves the door
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && isopen == true)
        {
			audioSource.PlayOneShot(Movesound);
            gameObject.transform.Translate(-5, 0, 0);
            isopen = false;
        } 
    }
}

