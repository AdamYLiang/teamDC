using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class killTrigger : MonoBehaviour {

	//Cant find for inactive objects
	//Maybe do an empty parent and then change it based off of that? 

	public GameObject P1;
	public Text playerText;
	public bool unlockerDead;

	void Start(){
		P1 = GameObject.Find("P1");
		playerText = GameObject.Find("winText").GetComponent<Text>();
		unlockerDead = false;
	}

	void Update(){

		if(unlockerDead){
			playerText.text = "Unlocker Has Died!";
		}
		
	}

	void OnTriggerEnter(Collider activator){
		if(activator.name == "P1"){
			unlockerDead = true;
			P1.SetActive(false);
			Debug.Log("You're dead");
		}
	}

}

