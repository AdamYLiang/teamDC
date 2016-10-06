using UnityEngine;
using System.Collections;

public class atkAtk : MonoBehaviour {

	//When an enemy is inside the hitbox, press the correct button to kill it
	//Currently AOE around the player
	void OnTriggerStay(Collider activator){

		if(activator.tag == "enemy"){

			Debug.Log("Attack it!");

			if(Input.GetKeyDown(KeyCode.M) || (Input.GetAxis("atkAbility") == 1)){
				Debug.Log("Kill it with fire");
				Destroy(activator.gameObject);
			}
		}

	}
}
