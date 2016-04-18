using UnityEngine;
using System.Collections;

public class planetControl : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate(new Vector3(speed,0,0));

	}
}
