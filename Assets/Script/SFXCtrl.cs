using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXCtrl : MonoBehaviour {
	public SFX sfx;
	public static SFXCtrl instance;


	void Awake(){
		if (instance == null)
			instance = this;

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void WinSparkles(Vector3 pos){
		Instantiate (sfx.winsparkle,pos,Quaternion.identity);
	}

	public void ShowkeySparkles(Vector3 pos){
		Instantiate (sfx.keyparkle,pos,Quaternion.identity);
	}
	public void lockSparkles(Vector3 pos){
		Instantiate (sfx.lockparkle,pos,Quaternion.identity);
	}

}
