using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class winTheGame : MonoBehaviour {

	public Text winText;
	bool p1In;
	bool p2In;

	void Start(){

		winText = GameObject.Find("winText").GetComponent<Text>();
		p1In = false;
		p2In = false;
		
	}

	void OnTriggerStay (Collider activator){

		//Debug.Log("The one inside is " + activator.name);

		if(activator.name == "P1") {
			p1In = true;
		}

		if(activator.name == "P2"){
			p2In = true;
		}

		if(p1In && p2In){
			//Debug.Log("Say a win");
			winText.text = "Congrats You Won!";
		}

	}

	void OnTriggerExit (Collider activator) {

		if(activator.name == "P1") {
			p1In = false;
		}

		if(activator.name == "P2"){
			p2In = false;
		}


	}
}
