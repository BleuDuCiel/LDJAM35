using UnityEngine;
using System.Collections;

public class wallControl : MonoBehaviour {

	private float wallSpeed;


	// Use this for initialization
	void Start () {
		wallSpeed = -0.1f;

	}
	
	// Update is called once per frame
	void Update () {

		if (gameManager.gamePaused) {

		} else {
			
			float dz = gameObject.transform.position.z;
			Vector3 nt = new Vector3 (gameObject.transform.position.x, gameObject.transform.position.y, dz + wallSpeed);
			gameObject.transform.position = nt;

		}
	}


}
