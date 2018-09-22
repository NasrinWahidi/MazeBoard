using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicLoad: MonoBehaviour {
	
		void Awake(){
		Screen.sleepTimeout = SleepTimeout.NeverSleep;

		GameObject[] obj=GameObject.FindGameObjectsWithTag("music");

		if (obj.Length > 1)
			Destroy (this.gameObject);
		DontDestroyOnLoad (this.gameObject);


	}

	}


		

