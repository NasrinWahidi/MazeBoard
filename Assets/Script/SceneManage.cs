using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void loadScene(int levelnum){
		SceneManager.LoadScene (levelnum);
		GameObject.Find ("bgMusic").GetComponent<AudioSource> ().mute = false;


	}
	public void restlevel(int levelnum){
		Time.timeScale = 1;
		SceneManager.LoadScene (levelnum);
	}
}
