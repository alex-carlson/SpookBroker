using UnityEngine;
using System.Collections;

public class economy : MonoBehaviour {

	public int heartCost = 5;
	public int jarCost = 5;
	public int boneCost = 5;
	public int fireCost = 5;

	int[] tempStorage = {5,5,5,5};

	// Use this for initialization
	void Start () {
		newEcon();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.U)){
			newEcon();
		}
	}

	public void newEcon(){
		for(int i = 0; i < 4; i++){
			int v = UpOrDown ();


			tempStorage [i] += v;

			if (tempStorage [i] > 8) {
				tempStorage [i] = 8;
			}

			if (tempStorage [i] < 1) {
				tempStorage [i] = 1;
			}
		}
		heartCost = tempStorage [0];
		jarCost = tempStorage [1];
		boneCost = tempStorage [2];
		fireCost = tempStorage [3];
		Debug.Log ("Stocks Adjusted");

	}

	public int UpOrDown(){
		float x = Random.value;

		if (x > 0.5f) {
			int v = 1;
			return v;
		} else {
			int v = -1;
			return v;
		}
	}
}
