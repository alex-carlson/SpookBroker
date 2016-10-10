using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum textItem { heart, jar, bone, fire };

public class updateInv : MonoBehaviour {

	public textItem myType;

	GameObject plr;

	void Start(){
		plr = GameObject.FindGameObjectWithTag ("Player");
	}

	public void JustDoIt(){
		if(myType == textItem.heart){
			GetComponentInChildren<Text>().text = ": "+plr.GetComponent<inventory> ().hearts;
		} else if(myType == textItem.jar){
			GetComponentInChildren<Text>().text = ": "+plr.GetComponent<inventory> ().jars;
		} else if(myType == textItem.bone){
			GetComponentInChildren<Text>().text = ": "+plr.GetComponent<inventory> ().bones;
		} else {
			GetComponentInChildren<Text>().text = ": "+plr.GetComponent<inventory> ().fires;
		}
	}
}
