using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockCtrl : MonoBehaviour {
	//public GameData data;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

//	public void lock(){
//
//
//	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.CompareTag("Player")){
			if(GameCtrl.instance.data.keyFond[0] && GameCtrl.instance.data.keyFond[1] && GameCtrl.instance.data.keyFond[2]){
				SFXCtrl.instance.lockSparkles(col.gameObject.transform.position);
				AudioCtrl.instance.KeyFond(col.gameObject.transform.position);
				Destroy (gameObject);

		
			}

		}
	}
}
