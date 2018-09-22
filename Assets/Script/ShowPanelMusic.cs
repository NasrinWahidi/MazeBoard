using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowPanelMusic : MonoBehaviour {

	public Slider volume;
	public GameObject panelMusic;
	public AudioSource mymusic; 

//	void Awake(){
//		
//	}

	void Start () {
		PlayerPrefs.SetFloat ("vol",1);
		mymusic = GameObject.FindGameObjectWithTag ("music").GetComponent<AudioSource>();

		volume.maxValue = 1;
		//mymusic.volume = 1;

		mymusic.volume = PlayerPrefs.GetFloat ("vol");
		volume.value = PlayerPrefs.GetFloat ("vol");
	}
	void Update(){
		mymusic.volume =volume.value;
		PlayerPrefs.SetFloat ("vol",volume.value);
	}

	public void Dontshowpanel(){
		panelMusic.gameObject.SetActive(false);

	}

	public void showpanel(){
		panelMusic.gameObject.SetActive(true);

	}

	void OnLevelWasLoaded(){
		mymusic = GameObject.FindGameObjectWithTag ("music").GetComponent<AudioSource>();
		volume.value = PlayerPrefs.GetFloat ("vol");
		mymusic.volume = PlayerPrefs.GetFloat ("vol");
//		print (PlayerPrefs.GetFloat ("vol"));
//		print (mymusic.volume);
	}
}
