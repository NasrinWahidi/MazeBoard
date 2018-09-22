using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour {

	public void linkIn(){

		Application.OpenURL ("https://www.linkedin.com/in/nasrin-wahidi-74392a168/");
	}

	public void twitter(){

		Application.OpenURL ("https://twitter.com/NasrinWahidi");
	}

	public void gmail(){

		Application.OpenURL ("https://mail.google.com/mail/u/0/");
	}


	public void Gethub(){

		Application.OpenURL ("https://github.com/NasrinWahidi/MazeBoard");
	}
}
