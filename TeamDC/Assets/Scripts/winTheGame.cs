using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winTheGame : MonoBehaviour {

	public Text winText;
	bool p1In;
	public int loadThis; //assign in inspector
	//bool p2In;

	void Start(){

		winText = GameObject.Find("winText").GetComponent<Text>();
		p1In = false;
		//p2In = false;

	}

	void OnTriggerStay (Collider activator){

		//Debug.Log("The one inside is " + activator.name);

		if(activator.name == "MainP") {
			p1In = true;
		}

		if(activator.name == "P2"){
			//p2In = true;
		}

		if(p1In){
			//Debug.Log("Say a win");
			winText.text = "Congrats You Won!";
			Invoke("loadNextScene", 2f);

		}

	}

	void OnTriggerExit (Collider activator) {

		if(activator.name == "MainP") {
			p1In = true;
		}

		if(activator.name == "P2"){
			//p2In = false;
		}


	}

	void loadNextScene(){
		SceneManager.LoadScene(loadThis);
	}
}
