using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameTimer : MonoBehaviour {
	public Text TimerText;
	float timers=0f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timers += Time.deltaTime;
		int second = (int)( timers % 60);
		int minutes=(int)( timers/60)%60;
		int hours=(int)( timers/3600)%24;
		string timerString = string.Format ("{1:00}:{2:00}",hours,minutes,second);
		TimerText.text = timerString;

		
	}
}
