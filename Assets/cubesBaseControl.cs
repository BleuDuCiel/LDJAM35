using UnityEngine;
using System.Collections;

public class cubesBaseControl : MonoBehaviour {

	public float speedRot;
	public Transform cube;

	private int nbCubes;

	// Use this for initialization
	void Start () {
		nbCubes = 5;
		//addCubes (nbCubes);
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.gamePaused) {

		} else {
			
	

			if (Input.GetKey ("left")) {
				rotate (1f);
			}
		
			if (Input.GetKey ("right")) {
				rotate (-1f);
			}

		}

	}

	private void rotate(float s){
		gameObject.transform.Rotate(new Vector3(0,0,speedRot*s));
	}

	private void addCubes(int nbC){
		int ang = 360/nbC;
		int sang = 0;

		for (int i=0; i<nbC; i++) {
			Transform g = Instantiate(cube);
			g.GetChild(0).transform.position = new Vector3(0,nbC-1,0);
			Debug.Log(g.GetChild(0).transform.position);
			g.transform.Rotate(new Vector3(0,0,sang+ang));
			g.transform.SetParent(gameObject.transform);
			sang += ang;
		}
	}

}
