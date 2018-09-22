using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PuaseCont : MonoBehaviour {
	

	public static bool gameIsPaused =false;
	public GameObject PuasePanel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pause(){

		Camera.main.GetComponent<AudioListener> ().enabled = false;
		PuasePanel.gameObject.SetActive (true);
		Time.timeScale = 0f;
		gameIsPaused = true;
	}

	public void Resume(){
		
		Camera.main.GetComponent<AudioListener> ().enabled = true;
		Time.timeScale = 1f;
		gameIsPaused = false;
		PuasePanel.gameObject.SetActive (false);

	}
}
