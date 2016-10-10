using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class loadLevel : MonoBehaviour {

	public int SceneToLoad;
	public GameObject myText;
	GameObject fadePanel;
	float fade = 0;
	bool fO = false;
	bool fI = false;

	public float loc = 0;

	void Start(){
		fadePanel = GameObject.Find ("FadePanel");
	}

	void Update(){
		if (fO == true) {
			fadeOut ();
		}

		else if (fI == true) {
			fadeIn ();
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		myText.SetActive (true);
	}

	void OnTriggerExit2D(Collider2D col){
		myText.SetActive (false);
	}

	void OnTriggerStay2D(Collider2D col){
		if (Input.GetButtonDown ("Jump")) {
			//GameObject.FindGameObjectWithTag ("Player").transform.position = Vector3.zero;
			//SceneManager.LoadScene (SceneToLoad);
			fI = true;
			GameObject.Find ("LevelManager").GetComponent<economy> ().newEcon ();
		}
	}

	void fadeIn(){

		if(fade < 1){
			fade += Time.deltaTime;
			fadePanel.GetComponent<Image> ().color = new Color (0, 0, 0, fade);
		} else {
			Vector3 t = GameObject.FindGameObjectWithTag ("Player").transform.position;
			GameObject.FindGameObjectWithTag ("Player").transform.position = new Vector3 (loc, t.y, t.z);
			fI = false;
			fO = true;
		}
	}

	void fadeOut(){

		if (fade > 0) {
			fade -= Time.deltaTime;
			fadePanel.GetComponent<Image> ().color = new Color (0, 0, 0, fade);
		} else {
			Vector3 t = GameObject.FindGameObjectWithTag ("Player").transform.position;
			GameObject.FindGameObjectWithTag ("Player").transform.position = new Vector3 (loc, t.y, t.z);
			fO = false;
		}
	}


}
