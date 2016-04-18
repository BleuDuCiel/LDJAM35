using UnityEngine;
using System.Collections;

public class baseDestruction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("start");

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision col){
		Debug.Log ("collider");
	}

	void OnTriggerStay(Collider other){
		if (other.attachedRigidbody.gameObject.tag == "mBase") {
			Debug.Log ("triggered");
			Destroy (other.attachedRigidbody.gameObject);
		}
		

	}
}
