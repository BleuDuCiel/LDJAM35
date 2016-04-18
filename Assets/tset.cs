using UnityEngine;
using System.Collections;

public class tset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		gameObject.GetComponent<Rigidbody> ().AddForce (0, 0, -85f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
