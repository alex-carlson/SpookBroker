using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class togglePalette : MonoBehaviour {

	public Texture[] palettes;
	int index = 0;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Q)) {
			index++;
			if (index >= palettes.Length) {
				index = 0;
			}
			GetComponent<MeshRenderer> ().material.SetTexture ("_Palette", palettes [index]);
			Debug.Log (GetComponent<MeshRenderer>().material.name);
		}
	}
}
