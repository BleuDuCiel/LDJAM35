using UnityEngine;
using System.Collections;

public class baseCreator : MonoBehaviour {

	public Transform movingBase;

	public Transform[] terrainA;


	public Transform[] wallA;

	private int timer,nbWalls,curLvl;

	// Use this for initialization
	void Start () {
		timer = 399;
		nbWalls = 0;
		curLvl = 1;

	}
	
	// Update is called once per frame
	void Update () {
		if (gameManager.gamePaused) {

		} else {
			
			timer++;
			//Debug.Log (timer);
			Transform[] terrain = terrainA, wall = wallA;

			if (Input.GetKeyDown ("p") || timer >= 10 * 4 * 10) {
			
				switch (curLvl) {
				case 1:
					terrain = terrainA;
					wall = wallA;
					break;

				case 2:
					break;

				default :
					Debug.LogError ("Default case on switch in baseCreator, should never happen");
					break;

				}


			

				createBase (terrain, wall);
				timer = 0;
				nbWalls++;
				if (nbWalls >= 2) {
					nbWalls = 0;
					curLvl++;
				}
			}
		}
	
	}


	private void createBase(Transform[] terrain, Transform[] wall){
		Transform mB = Instantiate (movingBase);
		Transform t = Instantiate (terrain[(int)(Random.value*terrain.Length)]);
		Transform w = Instantiate (wall[(int)(Random.value*wall.Length)]);

		w.transform.Rotate (new Vector3 (0, 0, Random.value * 360f));

		t.transform.SetParent (mB);
		w.transform.SetParent (mB);

		//Vector3 v = new Vector3 (transform.position.x, transform.position.y - 50, transform.position.z);


		//écarter les bases de 40
		mB.transform.position = new Vector3(transform.position.x,transform.position.y,200f);

		//side bases
		for (int i = 1; i < 6; i++) {
			Transform smB = Instantiate (movingBase);
			Transform st = Instantiate (terrain [(int)(Random.value * terrain.Length)]);

			st.transform.SetParent (smB);

			smB.transform.position = new Vector3 (transform.position.x + i*40, 0, 200f);
		}

		for (int i = 1; i < 6; i++) {
			Transform smB = Instantiate (movingBase);
			Transform st = Instantiate (terrain [(int)(Random.value * terrain.Length)]);

			st.transform.SetParent (smB);

			smB.transform.position = new Vector3 (transform.position.x + -i*40, 0, 200f);
		}

			

	}
}
