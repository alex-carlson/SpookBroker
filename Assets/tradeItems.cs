using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Item { heart, jar, bone, fire };

public class tradeItems : MonoBehaviour {

	public Item myItem;
	public Item yourItem;
	int cost = 4;
	economy econ;
	GameObject player;

	void Start(){
		econ = GameObject.Find ("LevelManager").GetComponent<economy> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerEnter2D(Collider2D col){
		if (myItem == Item.heart) {
			cost = econ.heartCost;
		} else if (myItem == Item.jar) {
			cost = econ.jarCost;
		} else if (myItem == Item.bone) {
			cost = econ.boneCost;
		} else if (myItem == Item.fire) {
			cost = econ.fireCost;
		}

		Offer ();
	}

	void OnTriggerExit2D(Collider2D col){
	}

	void OnTriggerStay2D(Collider2D col){
		if (Input.GetButtonDown ("Jump")) {
			Trade ();
		}
	}

	void Offer(){
		GetComponent<triggerDialogue> ().myText.GetComponent<Text> ().text = "I'll trade you, \n "+cost+" "+yourItem+"(s) -> 5 "+myItem+"(s)";
	}

	void Trade(){

		if (yourItem == Item.heart) {
			if (player.GetComponent<inventory> ().hearts < cost) {
				return;
			}
			player.GetComponent<inventory> ().hearts -= cost;

		} else if (yourItem == Item.jar) {
			if (player.GetComponent<inventory> ().jars < cost) {
				return;
			}
			player.GetComponent<inventory> ().jars -= cost;
		} else if (yourItem == Item.bone) {
			if (player.GetComponent<inventory> ().bones < cost) {
				return;
			}
			player.GetComponent<inventory> ().bones -= cost;
		} else {
			if (player.GetComponent<inventory> ().fires < cost) {
				return;
			}
			player.GetComponent<inventory> ().fires -= cost;
		}


		if (myItem == Item.heart) {
			player.GetComponent<inventory> ().hearts += 5;

		} else if (myItem == Item.jar) {
			player.GetComponent<inventory> ().jars += 5;
		} else if (myItem == Item.bone) {
			player.GetComponent<inventory> ().bones += 5;
		} else {
			player.GetComponent<inventory> ().fires += 5;
		}

		updateInv[] upade = GameObject.FindGameObjectWithTag ("PlayerInv").GetComponentsInChildren<updateInv> ();

		for(int i = 0; i <= 4; i++){
			upade [i].JustDoIt ();
		}
	}
}
