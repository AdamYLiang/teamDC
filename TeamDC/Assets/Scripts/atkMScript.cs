using UnityEngine;
using System.Collections;

public class atkMScript : MonoBehaviour {

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

		moveDirection.x = Input.GetAxis("Atk Horizontal") * moveSpeed;
		moveDirection.z = Input.GetAxis("Atk Vertical") * moveSpeed;
		moveDirection = transform.TransformDirection(moveDirection);

		ACharC.Move(moveDirection * Time.deltaTime);

	
	}
}
