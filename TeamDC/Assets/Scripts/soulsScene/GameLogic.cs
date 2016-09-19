using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {

	//Bugs:
	//If the same color is selected, it sometimes marks it as wrong
	//Could be timing based, could be how you coded the pattern passing, asychronous? 
	//Problem lies with the random, it is not keeping up the same button key even though the two are the same
	//Try to figure out why the color isnt correctly corresponding with the button.

	//JK ITS WORKING NOW

	//TODO: Attack patterns?
	//Press first letter of the color to correctly hit it

	public Text correctText;
	public Text incorrectText;
	public static int correctCounter;
	public static int incorrectCounter;
	public int playerAttack;
	public GameObject monster;
	public float diffCounter;

	// Use this for initialization
	void Start () {
	
		correctCounter = 0;
		incorrectCounter = 0;
		correctText.text = "Correct Hits: " + correctCounter;
		incorrectText.text = "Wrong Hits: " + incorrectCounter;
		playerAttack = 0; 

	}
	
	// Update is called once per frame
	void Update () {

		playerAttack = monster.GetComponent<MonsterController>().pattern;
		diffCounter = monster.GetComponent<MonsterController>().diffiCount;
		//Debug.Log("Player pattern is: " + playerAttack);

		if(Input.GetKeyDown(KeyCode.G) && monster.GetComponent<MonsterController>().attackNotCD){

			if(playerAttack == 2){
				correctCounter++;
				if(diffCounter < 2){
					monster.GetComponent<MonsterController>().diffiCount += 0.3f; 
				}
			}
			else incorrectCounter++;

			Debug.Log("Pattern was " + playerAttack + " and the player hit G " + monster.GetComponent<MonsterController>().pattern);
			monster.GetComponent<MonsterController>().attackNotCD = false;
		}

		else if(Input.GetKeyDown(KeyCode.B) && monster.GetComponent<MonsterController>().attackNotCD){
			
			if(playerAttack == 1){
				correctCounter++;
				if(diffCounter < 2){
					monster.GetComponent<MonsterController>().diffiCount += 0.3f; 
				}
			}
			else incorrectCounter++;

			Debug.Log("Pattern was " + playerAttack + " and the player hit B, monster pattern was " + monster.GetComponent<MonsterController>().pattern);
			monster.GetComponent<MonsterController>().attackNotCD = false;
		}

		else if(Input.GetKeyDown(KeyCode.Y) && monster.GetComponent<MonsterController>().attackNotCD){
			if(playerAttack == 3){
				correctCounter++;
				if(diffCounter < 2){
					monster.GetComponent<MonsterController>().diffiCount += 0.3f; 
				}
			}
			else incorrectCounter++;

			Debug.Log("Pattern was " + playerAttack + " and the player hit Y " + monster.GetComponent<MonsterController>().pattern);
			monster.GetComponent<MonsterController>().attackNotCD = false;
		}

		correctText.text = "Correct Hits: " + correctCounter;
		incorrectText.text = "Wrong Hits: " + incorrectCounter;

		Debug.Log(diffCounter);
	}
}
