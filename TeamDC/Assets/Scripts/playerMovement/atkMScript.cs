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

	//Rotate to face the direction you push

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

		//Updated Movecode 
		float atkHorizontal = Input.GetAxis("Atk Horizontal");
		float atkVertical = Input.GetAxis("Atk Vertical");

		//Outdated
//		moveDirection.x = Input.GetAxis("Atk Horizontal") * moveSpeed;
//		moveDirection.z = Input.GetAxis("Atk Vertical") * moveSpeed;
//		moveDirection = transform.TransformDirection(moveDirection);

		Vector3 movement = (((transform.forward * atkVertical) + ((transform.right) * atkHorizontal)).normalized * moveSpeed);

		ACharC.Move(movement * Time.deltaTime);
		//ACharC.Move(moveDirection * Time.deltaTime);
	
	}
}
