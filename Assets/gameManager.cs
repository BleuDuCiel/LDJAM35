using UnityEngine;
using System.Collections;

public class gameManager : MonoBehaviour {

	//0=in menu 1=playing 2=win 3=lose
	private int gameState;
	public static bool gamePaused;
	// Use this for initialization
	void Start () {
		gameState = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("gameState is " + gameState);
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Debug.Log ("escape, gameState is " + gameState);
			if (gameState == 0) {
				resumeGame ();
			}
			if (gameState == 1) {
				pauseGame ();
			}

		}
	

	
	}

	private void pauseGame(){
		Debug.Log ("pause");
		gamePaused = true;
		gameState = 0;
	}

	private void resumeGame(){
		Debug.Log ("resume");
		gamePaused = false;
		gameState = 1;
	}
}
