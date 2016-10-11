using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class basicSwitch : MonoBehaviour {

    [SerializeField]
    List<GameObject> blocksToTurnOff = new List<GameObject>(); //create a list of objects to turn off, assign number and objects in inspector

    

	void OnTriggerEnter (Collider activator) {
        if (activator.tag == "Player") //if player enters "the switch"
        {
            foreach (GameObject block in blocksToTurnOff) //set all gameobjects in the list to false
            {
                block.SetActive(false);
            }
        }
	}
}
