using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallCtrl : MonoBehaviour {
	public static BallCtrl instance;
	Rigidbody2D rb;
	//public Transform startPos;

	public float ModifireSpeed;

	float dirx,diry;
	Animator anim;
	static bool isDaed;
	static bool MoveAllowed;

	public float restartDelay;
	public GameObject GameOverPanel;
	GameObject playerCont;


	static bool youWin;
	//public GameObject Win;


	void Awake(){
		if (instance == null)
			instance = this;
	} 



	// Use this for initialization
	void Start () {
		isDaed = false;
		youWin = false;
		MoveAllowed = true;

		rb = GetComponent<Rigidbody2D> ();
		anim= GetComponent<Animator> ();

		anim.SetBool ("BallDead",isDaed);


	}
	
	// Update is called once per frame
	void Update () {

		dirx = Input.acceleration.x * ModifireSpeed;
		diry = Input.acceleration.y * ModifireSpeed;

		if(isDaed){
			rb.velocity=new Vector2(0,0);
			anim.SetBool ("BallDead",isDaed);
			//Invoke ("RestartScene",1.5f);

		}
		if(youWin){
			MoveAllowed = false;
			anim.SetBool ("BallDead",true);
	
		}

	}

	void FixedUpdate(){
		if (MoveAllowed)
			rb.velocity = new Vector2 (rb.velocity.x+dirx,rb.velocity.y+diry);


	}
	public static void setIsDeadTrue(){
		isDaed = true;



	}

	public static void setIsWinTrue(){
		
		youWin = true;
	
	}

	void RestartScene(){
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	
}



	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.CompareTag("blackEnemy")){
			GameOverPanel.SetActive (true);
			GameObject.Find ("bgMusic").GetComponent<AudioSource> ().mute = true;
			gameObject.SetActive (false);
			//Invoke ("RestartLevel",restartDelay);
		}

	}

	public void RestartLevel(int LevelNum){
		SceneManager.LoadScene (LevelNum);
	}

}

