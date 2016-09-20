using UnityEngine;
using System.Collections;

public class unlkrMScript : MonoBehaviour {

	//THIS IS FOR THE UNLOCKER 
	//USE "UNLOCK" FOR RELEVANT METHODS

	public Vector3 moveDirection;
	private CharacterController charc;
	//private string playerName;
	public int moveSpeed;

	// Use this for initialization
	void Start () {
	
		charc = GetComponent<CharacterController>();
		//playerName = "P1";
		moveSpeed = 35;

	}
	
	// Update is called once per frame
	void Update () {
	
		//Basic movement code
		moveDirection.x = Input.GetAxis("Unlock Horizontal") * moveSpeed;
		moveDirection.z = Input.GetAxis("Unlock Vertical") * -moveSpeed;
		moveDirection = transform.TransformDirection(moveDirection);

		charc.Move(moveDirection * Time.deltaTime);

	}
}
