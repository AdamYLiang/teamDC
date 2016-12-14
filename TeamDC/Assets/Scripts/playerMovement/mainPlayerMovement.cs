using UnityEngine;
using System.Collections;

public class mainPlayerMovement : MonoBehaviour {

	//TODO
	//Fix the enemies
	//Check to see that everything still works, it's all hooked up right
	//Gameobejct.Find is useless, you have ASSIGN THROUGH INSPECTOR
	//Find a workaround, maybe parent with an empty object?
	//Make sure that the spawning code is resilient, wont get broken later down the line
	//Set to make sure the player has to pick up the shell of the hacker/buster
	//Child object that turns on? 
	//Cooldown for spawning? Cant spawn attack into attacker has to alternate?

	//Make it so that instead of setting active it sets the script enabled
	//That way leaving a shell behind is easier

	//Bool to check if you can spawn it, make it drop a shadow when a spawner dies, picking up shadow makes it easy.


	public Vector3 moveDirection;
	private CharacterController charc;
	//private string playerName;
	public int moveSpeed;

	//Assign players in inspector and set them inactive.
	public GameObject P1;
	public GameObject P2;

	public bool P1FirstSpawn;
	public bool P2FirstSpawn;

	public bool canSpawnP1;
	public bool canSpawnP2;

    

    void Start () {
	
		charc = GetComponent<CharacterController>();
		//playerName = "P1";
		moveSpeed = 5;

		P1FirstSpawn = true;
		P2FirstSpawn = true;
		canSpawnP1 = true;
		canSpawnP2 = true;
    }
	
	// Update is called once per frame
	void Update () {

       //float unlockHorizontal = Input.GetAxisRaw("Horizontal");
		//float unlockVertical = Input.GetAxisRaw("Vertical");
		//Vector3 movement = (((transform.forward * unlockVertical) + ((transform.right) * unlockHorizontal)).normalized * moveSpeed);

		Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		movement *= moveSpeed;

		if (movement != Vector3.zero){
			transform.rotation = Quaternion.LookRotation(movement);
		}

		charc.Move(movement * Time.deltaTime);


	}}

