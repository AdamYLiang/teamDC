using UnityEngine;
using System.Collections;

public class cbMonster : MonoBehaviour {

	public GameObject P1;
	public GameObject P2;
	public float speed; //Speed of enemy
	public LayerMask layerM; //Layermask to ignore attacker layer 8
	public int aggroLength; //When the enemy will start chasing player

	// Use this for initialization
	void Start () {
		speed = 10f;
		P1 = GameObject.Find("MainP");
		P2 = GameObject.Find("P2");

		//Bitshift to get the right layer then invert
		layerM = (1<<8);
		layerM = ~layerM;

		aggroLength = 55; //small room is 41
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Raycasts to player, if there is no wall then chase the player
		Vector3 directionToUnlocker = P1.transform.position - transform.position;
		float uAngle = Vector3.Angle(transform.forward, directionToUnlocker);

		if(uAngle < 180){
			Ray enemyRay = new Ray(transform.position, directionToUnlocker);
			RaycastHit enemyRayInfo = new RaycastHit();

			//Debug.DrawRay(transform.position, directionToUnlocker);

			//If ray is hitting anything that is NOT layer 8 
			if(Physics.Raycast(enemyRay, out enemyRayInfo, 100f, layerM)){

				if(enemyRayInfo.collider.name == "P1"){
					//Debug.Log(enemyRayInfo.distance);

					if(enemyRayInfo.distance <= aggroLength){
						Debug.Log("Chase it!");

						//GetComponent<Rigidbody>().AddForce(directionToUnlocker.normalized * 10f);
						transform.position = Vector3.MoveTowards(transform.position, P1.transform.position, speed * Time.deltaTime);

					}

				
				}

			}
		}
		
	}
}
