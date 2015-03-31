using UnityEngine;
using System.Collections;

public class LevelManagement : MonoBehaviour {

	public int currentLevel;	





	//sets level to 1 and makes object numbers permanent
	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
		currentLevel = 0;
	}

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//loads next level when player hits this object
	void OnTriggerEnter2D (Collider2D whatHitMe)
	{
		if (whatHitMe.gameObject.tag == "Player") 
		{
			Debug.Log("HERE");
			Application.LoadLevel(currentLevel + 1);
			Destroy(gameObject);
		}

	}

}
