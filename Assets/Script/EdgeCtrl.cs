using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EdgeCtrl : MonoBehaviour {
	public Transform sponPos;
	public Transform oldPos;
	public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("Player")){
			col.gameObject.SetActive (false);
			Invoke ("sponposition",3.0f);

		}


	}

	void sponposition(){
		
		player.SetActive (true);
		player.transform.position=sponPos.position;


	}
}
