using UnityEngine;
using System.Collections;

public class AudioMaster : MonoBehaviour {



	static void playerNormal(AudioSource bgmSource, AudioClip clip)
	{
			if (bgmSource.clip != clip)
		{
			bgmSource.Stop();
			bgmSource.loop = true;
			bgmSource.clip = clip;
			bgmSource.Play();		
		}
			
	}


	void OnEnable()
	{
		Character.normMusicEnabled += playerNormal;
	}
	
	void OnDisable()
	{
		Character.normMusicEnabled -= playerNormal;
	}
}

