using UnityEngine;
using System.Collections;

public class cbMonster : MonoBehaviour {

	public GameObject P1;
	public GameObject P2;
	public float speed; //Speed of enemy
	public LayerMask layerM; //Layermask to ignore attacker layer 8
	public int aggroLength; //When the enemy will start chasing player
	public bool lockedOn;

	// Use this for initialization
	void Start () {
		speed = 10f;
		P2 = GameObject.Find("MainP");

		//Bitshift to get the right layer then invert
		layerM = (1<<8);
		layerM = ~layerM;
		lockedOn = false;

		aggroLength = 55; //small room is 41
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Raycasts to player, if there is no wall then chase the player
		//Vector3 directionToUnlocker = P1.transform.position - transform.position;
		//float uAngle = Vector3.Angle(transform.forward, directionToUnlocker);

		//if(uAngle < 180){
		Vector3 lowerBody = new Vector3(transform.position.x, 0.8f, transform.position.z);
		Ray enemyRay = new Ray(lowerBody, transform.forward);
		RaycastHit enemyRayInfo = new RaycastHit();
			//Debug.DrawRay(transform.position, directionToUnlocker);

			//If ray is hitting anything that is NOT layer 8 
			if(Physics.Raycast(enemyRay, out enemyRayInfo, 50f)){
			Debug.DrawRay(lowerBody, transform.forward * 50f, Color.blue);
			//Debug.Log(enemyRayInfo.collider.name);
				if(enemyRayInfo.collider.name == "P1"){
					//Debug.Log(enemyRayInfo.distance);

					//if(enemyRayInfo.distance <= aggroLength){
					Debug.Log("Chase it!");
					lockedOn = true;
					P1 = enemyRayInfo.collider.gameObject;
						//GetComponent<Rigidbody>().AddForce(directionToUnlocker.normalized * 10f);
						//transform.position = Vector3.MoveTowards(transform.position, P1.transform.position, speed * Time.deltaTime);
					//}

				
				}

			}

		if(lockedOn){
			Vector3 directionToPlayer = P1.transform.position - transform.position;
			float uAngle = Vector3.Angle(transform.forward, directionToPlayer);
			if(uAngle < 180){
				Ray findPlayerRay = new Ray(transform.position, directionToPlayer);
				RaycastHit findPlayerRayInfo = new RaycastHit();

				if(Physics.Raycast(findPlayerRay, out findPlayerRayInfo, 100f)){
					if(findPlayerRayInfo.collider.name == "P1"){
						if(findPlayerRayInfo.distance < aggroLength){
							transform.position = Vector3.MoveTowards(transform.position, P1.transform.position, speed * Time.deltaTime);
						}
					}
				}
			}
		}

		//}
		
	}
}
