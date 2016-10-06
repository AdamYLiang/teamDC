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
		moveSpeed = 35;

		P1FirstSpawn = true;
		P2FirstSpawn = true;
		canSpawnP1 = true;
		canSpawnP2 = true;
    }
	
	// Update is called once per frame
	void Update () {

        float unlockHorizontal = Input.GetAxis("Unlock Horizontal");
		float unlockVertical = Input.GetAxis("Unlock Vertical");
		Vector3 movement = (((transform.forward * unlockVertical) + ((transform.right) * unlockHorizontal)).normalized * moveSpeed);

		//Oudated move code 
		//		moveDirection.x = Input.GetAxis("Unlock Horizontal") * moveSpeed;
		//		moveDirection.z = Input.GetAxis("Unlock Vertical") * moveSpeed;
		//		moveDirection = transform.TransformDirection(moveDirection);

		charc.Move(movement * Time.deltaTime);

		//FOR FIRES THE TWO ARE REVERSED, FIRE 1 = HACKER, FIRE 2 = UNLOCKER
		//Spawning in the respective roles
		if((Input.GetButtonDown("Fire1")) && canSpawnP1){
			Debug.Log("Spawn Buster");

			P1.transform.position = this.gameObject.transform.position;
			P1.SetActive(true);
			canSpawnP1 = false;
			this.gameObject.GetComponent<mainPlayerMovement>().enabled = false;
			//moveSpeed = 0;
			//this.gameObject.SetActive(false);
		}

		//Code to swap between the two spawners
		//it will check if it is the first spawn, if so it will spawn on top of main
		//If not it will spawn where it used to be
		//Un enables THiS SCRIPT so the image is still left behind.
		//FOR FIRES THE TWO ARE REVERSED, FIRE 1 = HACKER, FIRE 2 = UNLOCKER
		if((Input.GetButtonDown("Fire2")) && canSpawnP2){
			Debug.Log("Spawn Hacker");

		
			P2.transform.position = this.gameObject.transform.position;
			P2.SetActive(true);
			canSpawnP2 = false;
			this.gameObject.GetComponent<mainPlayerMovement>().enabled = false;
			//moveSpeed = 0;
			//this.gameObject.SetActive(false);
		}
        

    }
}
