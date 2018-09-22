using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCont : MonoBehaviour {

	public int keyNumber;

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("Player")){
			GameCtrl.instance.UpdateKey (keyNumber);
			SFXCtrl.instance.ShowkeySparkles(other.gameObject.transform.position);
			AudioCtrl.instance.KeyFond(other.gameObject.transform.position);
			Destroy (gameObject);

		}



	}
}
