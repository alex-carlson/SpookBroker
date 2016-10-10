using UnityEngine;
using System.Collections;

public class followTarget : MonoBehaviour {

	Transform target;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(transform.gameObject);
		target = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.position + offset;
	}
}
