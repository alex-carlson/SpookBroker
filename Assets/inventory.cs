using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class inventory : MonoBehaviour {

	public int hearts = 10;
	public int jars = 10;
	public int bones = 10;
	public int fires = 10;

	void Update(){
		if (Input.GetKey (KeyCode.I)) {
			hearts = 999;
			jars = 999;
			bones = 999;
			fires = 999;

			Text[] items = GameObject.FindGameObjectWithTag ("PlayerInv").GetComponentsInChildren<Text> ();

			for (int i = 0; i < 4; i++) {
				items [i].text = ": 999";
			}
		}
	}
}
