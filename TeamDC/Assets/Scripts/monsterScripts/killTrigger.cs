using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class killTrigger : MonoBehaviour {

	//Cant find for inactive objects
	//Maybe do an empty parent and then change it based off of that? 

	public GameObject P1;
    public GameObject P2;
    public GameObject mainP;
	public Text playerText;
	public bool unlockerDead;
    public bool explorerDead;
    public bool mainPDead;
    public bool iWillKill;

	void Start(){
		P1 = GameObject.Find("P1");
        P2 = GameObject.Find("P2");
        mainP = GameObject.Find("MainP");
		playerText = GameObject.Find("winText").GetComponent<Text>();
        mainPDead = false;
		unlockerDead = false;
        explorerDead = false;
        iWillKill = true;
    }

	void Update(){
        if (this.gameObject.tag == ("patrol"))
        {
            if (P2.GetComponent<atkMScript>().isCamoGreen == true)
            {
                iWillKill = false;
            }
            else { iWillKill = true; }
        }
        if (this.gameObject.tag == ("enemy"))
        {
            //if (P2.GetComponent<atkMScript>().isCamoRed == true)
         //   {
          //      iWillKill = false;
           // }
          //  else { iWillKill = true; }
        }
        

        if (unlockerDead){
			playerText.text = "Unlocker Has Died!";
            
		}
        if (explorerDead){
            playerText.text = "Explorer Has Died!";
        }
        if (mainPDead){
            playerText.text = "Hacker has died!";
        }
		
	}

	void OnTriggerEnter(Collider activator){

        Debug.Log(activator.name);
		if(activator.name == "P1"){
			unlockerDead = true;
			P1.SetActive(false);
			Debug.Log("You're dead");
		}
        if (activator.name == "P2")
        {
            if (iWillKill == true)
            {
                explorerDead = true;
                P2.SetActive(false);
                Debug.Log("exp dead");
            }
        }

        if (activator.name == "MainP")
        {
			Debug.Log("Kill main");
            mainPDead = true;
            mainP.SetActive(false);
        }
	}

}

