using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class killTrigger : MonoBehaviour {

	public GameObject P1;
	public Text playerText;
	public bool unlockerDead;

	void Start(){
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
			Destroy(P1);
			Debug.Log("You're dead");
		}
	}

}

