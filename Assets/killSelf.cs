using UnityEngine;
using System.Collections;

public class killSelf : MonoBehaviour {

	public float killTime = 0.1f;

	// Use this for initialization
	void Start () {
		Destroy (this.gameObject, killTime);
	}
}
