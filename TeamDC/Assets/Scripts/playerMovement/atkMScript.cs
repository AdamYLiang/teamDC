using UnityEngine;
using System.Collections;

public class atkMScript : MonoBehaviour {

	//TODO:
	//Make camera work, lets go with zoom out tracking
	//hook up a door, for now dont instantiate just open the door, triggers
	//Make an enemy, make it touch death 
	//Instantiate enemy through pathmakers? or hardcode works too 
	//Raycast to chase unlocker, AI algorithm 

	//If both players get together the map can flash? 
	//fog of war/monaco style lighting

	//bug, too many lights? rendering

	//THIS IS FOR THE ATTACKER
	//USE "ATK" FOR RELEVANT METHODS

	public Vector3 moveDirection;
	private CharacterController ACharC;
	//private string playerName;
	public int moveSpeed;

	// Use this for initialization
	void Start () {

		ACharC = GetComponent<CharacterController>();
		moveSpeed = 25;
	}
	
	// Update is called once per frame
	void Update () {

		//Basic movement code
		moveDirection.x = Input.GetAxis("Atk Horizontal") * moveSpeed;
		moveDirection.z = Input.GetAxis("Atk Vertical") * -moveSpeed;
		moveDirection = transform.TransformDirection(moveDirection);

		ACharC.Move(moveDirection * Time.deltaTime);
	
	}
}
