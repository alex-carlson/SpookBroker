using UnityEngine;
using System.Collections;

public class lightningSpawn : MonoBehaviour {

	public GameObject Lightning;
	Vector3 playerPos;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnLightning", 1, 5);
	}

	void SpawnLightning(){
		playerPos = GameObject.FindGameObjectWithTag ("Player").transform.position;
		Instantiate (Lightning, new Vector3 (Random.Range (-75, 75) + playerPos.x, 42, 4), Quaternion.identity);
	}
}
