using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCtrl : MonoBehaviour {

	public static AudioCtrl instance;
	public PlayerAudio playerAudio;


	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
	}
	
//	public void playerwin(Vector3 playerPos){
//		AudioSource.PlayClipAtPoint (playerAudio.WinExplosion, playerPos,4f);
//
//	}

//	public void playerDead(Vector3 playerPos){
//		AudioSource.PlayClipAtPoint (playerAudio.PlayerDead, playerPos);
//}

	public void KeyFond(Vector3 playerPos){
		//print (playerAudio.BallRolled.frequency);
		AudioSource.PlayClipAtPoint (playerAudio.Keyfond, playerPos);
	}

	public void LockFond(Vector3 playerPos){
		AudioSource.PlayClipAtPoint (playerAudio.lockfond, playerPos);
	}



}
