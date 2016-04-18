using UnityEngine;
using System.Collections;

public class cubeControl : MonoBehaviour {

	public float speedScale,startingScale,inv;

	private GameObject[] otherCubes;



	// Use this for initialization
	void Start () {
		gameObject.transform.localScale = new Vector3 (startingScale, startingScale, 1);

		Collider coll = gameObject.GetComponent<BoxCollider> ();
		otherCubes = GameObject.FindGameObjectsWithTag ("cubeTag");
		foreach(GameObject c in otherCubes){
			Physics.IgnoreCollision (coll, c.GetComponent<Collider>() );
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.gamePaused) {

		} else {
	
			if (Input.GetKey ("e")) {
				changeShape (inv);
			} 

			if (Input.GetKey ("d")) {
				changeShape (-inv);
			}

			changeColor ();

		}
	}

	void OnTriggerEnter(Collider col) {
		//Debug.Log (col.attachedRigidbody.gameObject);
		if (col.attachedRigidbody.gameObject.tag == "mBase") {
			//Debug.Log ("mBase, ignore");
		} else {
			Debug.Log ("was smth else");
		}



	}

	private void changeShape(float s){
		float sX = gameObject.transform.localScale.x;
		float sY = gameObject.transform.localScale.y;

		float th = 0.1f * startingScale;

		sX += speedScale * s * startingScale /2.5f;
		sY -= speedScale * s * startingScale /2.5f;

		if (sX < th) {
			sX = th;
			sY = 2.0f*startingScale-th;
		}
		if (sY < th) {
			sY = th;
			sX = 2.0f*startingScale-th;
		}


		gameObject.transform.localScale = new Vector3 (sX, sY, 1);
		//gameObject.GetComponent<BoxCollider>().transform.localScale = new Vector3 (sX, sY, 1);

	}


	private void changeColor(){
		float sX = gameObject.transform.localScale.x;
		float sY = gameObject.transform.localScale.y;
		float rZ = gameObject.transform.localRotation.eulerAngles.z;
		Color col = new Color(sX/startingScale,0.8f,sY/startingScale,0.8f);
		

		gameObject.GetComponent<Renderer>().material.SetColor("_Color",col);
	}

}
