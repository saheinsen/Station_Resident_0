using UnityEngine;
using System.Collections;

public class pauseMenu : MonoBehaviour {



	public void OnGUI()
	{
        //simple styling for pause menu
		GUI.backgroundColor = Color.black;
		GUI.contentColor = Color.white;
		GUI.Button(new Rect(50, 50, 500, 200), "Paused");
	}
}
