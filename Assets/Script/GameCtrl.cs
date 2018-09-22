using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameCtrl : MonoBehaviour {
	public GameData data;
	public static GameCtrl instance;

	void Awake(){
		if (instance == null)
			instance = this;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene ("Menu");

		}
	}


	public void UpdateKey(int keyNumber){
		data.keyFond [keyNumber] = true;
		 

		
	}

	void OnApplicationPause(){
		Application.Quit ();
	}

}
