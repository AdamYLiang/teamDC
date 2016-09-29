using UnityEngine;
using System.Collections;

public class unlkrMScript : MonoBehaviour {

	//THIS IS FOR THE UNLOCKER 
	//USE "UNLOCK" FOR RELEVANT METHODS

	public Vector3 moveDirection;
	private CharacterController charc;
	//private string playerName;
	public int moveSpeed;
	public GameObject mainP;

	// Use this for initialization
	void Start () {
	
		charc = GetComponent<CharacterController>();
		//playerName = "P1";
		moveSpeed = 35;

	}
	
	// Update is called once per frame
	void Update () {
	
		//Updated movement code
	
		float unlockHorizontal = Input.GetAxis("Unlock Horizontal");
		float unlockVertical = Input.GetAxis("Unlock Vertical");
		Vector3 movement = (((transform.forward * unlockVertical) + ((transform.right) * unlockHorizontal)).normalized * moveSpeed);

		//Oudated move code 
//		moveDirection.x = Input.GetAxis("Unlock Horizontal") * moveSpeed;
//		moveDirection.z = Input.GetAxis("Unlock Vertical") * moveSpeed;
//		moveDirection = transform.TransformDirection(moveDirection);

		charc.Move(movement * Time.deltaTime);


		//Debug.Log(Input.GetAxis("Door Horizontal"));

		//Go back to main
		if(Input.GetButtonDown("Fire1")){
			Debug.Log("Back to MC");
			//mainP.GetComponent<mainPlayerMovement>().moveSpeed = 35;
			mainP.gameObject.GetComponent<mainPlayerMovement>().enabled = true;
			mainP.gameObject.GetComponent<mainPlayerMovement>().P1FirstSpawn = false;
			mainP.SetActive(true);
			this.gameObject.SetActive(false);
		}

	}
}
