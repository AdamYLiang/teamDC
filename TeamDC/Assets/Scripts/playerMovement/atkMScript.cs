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
	//ATK IS P2

	public Vector3 moveDirection;
	private CharacterController ACharC;
	//private string playerName;
	public int moveSpeed;
	public GameObject mainP; //Assign in spector
	public GameObject p2Spawner;

    public bool isCamoGreen = false;
    public bool isCamoRed = false;

	// Use this for initialization
	void Start () {

		ACharC = GetComponent<CharacterController>();
		moveSpeed = 25;
		this.gameObject.SetActive(false);
        GetComponentInChildren<Light>().color = Color.white;
    }
	
	// Update is called once per frame
	/// <summary>
    /// 
    /// </summary>
    void Update () {

		//Updated Movecode 
		float atkHorizontal = Input.GetAxis("Unlock Horizontal");
		float atkVertical = Input.GetAxis("Unlock Vertical");

		//Outdated
//		moveDirection.x = Input.GetAxis("Atk Horizontal") * moveSpeed;
//		moveDirection.z = Input.GetAxis("Atk Vertical") * moveSpeed;
//		moveDirection = transform.TransformDirection(moveDirection);

		Vector3 movement = (((transform.forward * atkVertical) + ((transform.right) * atkHorizontal)).normalized * moveSpeed);

		ACharC.Move(movement * Time.deltaTime);
		//ACharC.Move(moveDirection * Time.deltaTime);

		//Same as the unlocker movement
		//it checks and then enables the script on the main character.
		//important since you still want the player to show up.
		if(Input.GetButtonDown("Fire2")){
			Debug.Log("Back to MC");
			//mainP.GetComponent<mainPlayerMovement>().moveSpeed = 35;
			mainP.gameObject.GetComponent<mainPlayerMovement>().enabled = true;
			mainP.gameObject.GetComponent<mainPlayerMovement>().P2FirstSpawn = false;
			mainP.SetActive(true);
			Instantiate(p2Spawner, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			this.gameObject.SetActive(false);
		}
       
        //setting up the camo lights
        if (Input.GetButtonDown("CamoGreen")&& isCamoRed == false)
        {
            Debug.Log("Changing color");

            if(GetComponentInChildren<Light>().color == Color.white)
            {
                Debug.Log("Lets go green");
                GetComponentInChildren<Light>().color = Color.green;
                isCamoGreen = true;
            }

            else  if (GetComponentInChildren<Light>().color == Color.green)
            {
                Debug.Log("lets go white");
                GetComponentInChildren<Light>().color = Color.white;
                isCamoGreen = false;
            }

        }
        if (Input.GetButtonDown("CamoRed") && isCamoGreen == false)
        {
            if (GetComponentInChildren<Light>().color == Color.white)
            {
                Debug.Log("Lets go red");
                GetComponentInChildren<Light>().color = Color.red;
                isCamoRed = true;
            }

            else if (GetComponentInChildren<Light>().color == Color.red)
            {
                Debug.Log("lets go white");
                GetComponentInChildren<Light>().color = Color.white;
                isCamoRed = false;
            }
        }

        }
}
