using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class killTrigger : MonoBehaviour {

	//Cant find for inactive objects
	//Maybe do an empty parent and then change it based off of that? 

	public GameObject P1;
    public GameObject mainP;
	public Text playerText;
	public bool unlockerDead;
    public bool mainPDead;

	void Start(){
		P1 = GameObject.Find("P1");
        mainP = GameObject.Find("MainP");
		playerText = GameObject.Find("winText").GetComponent<Text>();
        mainPDead = false;
		unlockerDead = false;
	}

	void Update(){

		if(unlockerDead){
			playerText.text = "Unlocker Has Died!";
		}
        if (mainPDead){
            playerText.text = "Hacker has died!";
        }
		
	}

	void OnTriggerEnter(Collider activator){
		if(activator.name == "P1"){
			unlockerDead = true;
			P1.SetActive(false);
			Debug.Log("You're dead");
		}

        if (activator.name == "MainP")
        {
            mainPDead = true;
            mainP.SetActive(false);
        }
	}

}

