using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[ExecuteInEditMode]
public class textFix : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().font.material.mainTexture.filterMode = FilterMode.Point;
	}
}
