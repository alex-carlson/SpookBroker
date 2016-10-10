using UnityEngine;
using System.Collections;

public class triggerDialogue : MonoBehaviour {

	public GameObject myText;

	void OnTriggerEnter2D(Collider2D col){
		myText.SetActive (true);
	}

	void OnTriggerExit2D(Collider2D col){
		myText.SetActive (false);
	}


}
