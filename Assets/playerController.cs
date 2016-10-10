using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	Animator m_anim;
	public float speed = 2;

	// Use this for initialization
	void Start () {
		m_anim = GetComponent<Animator> ();
		DontDestroyOnLoad(transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.O)){
			if(speed< 10){
				speed = 10;
			} else {
				speed = 2;
			}
		}
			
		m_anim.SetFloat("speed", Mathf.Abs(Input.GetAxis ("Horizontal")));
		if (Input.GetAxis ("Horizontal") != 0) {
			Move ();
		} 
		//m_anim.speed = Mathf.Abs (Input.GetAxis ("Horizontal"));
	}

	void Move(){
		transform.Translate (Input.GetAxis ("Horizontal") * speed, 0, 0);
		if (Input.GetAxis ("Horizontal") < 0) {
			GetComponent<SpriteRenderer> ().flipX = true;
		} else {
			GetComponent<SpriteRenderer> ().flipX = false;
		}
	}
}
