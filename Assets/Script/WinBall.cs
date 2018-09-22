using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinBall : MonoBehaviour {
	public GameObject LevelComplete;
	public GameObject Ballcon;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D col){
		BallCtrl.setIsWinTrue ();
		if (col.gameObject.CompareTag ("Player")){
			SFXCtrl.instance.WinSparkles (gameObject.transform.position);
			//AudioCtrl.instance.playerwin (gameObject.transform.position);
			Invoke ("LevelCompletePanel",0.5f);
		

		//	col.gameObject.transform.position.x = 0;
			//SceneManager.LoadScene ("Level2");
		
		}
	}
	void LevelCompletePanel(){	
		LevelComplete.SetActive (true);
		GameObject.Find ("bgMusic").GetComponent<AudioSource> ().mute = true;
		Ballcon.gameObject.SetActive (false);
	}
}
