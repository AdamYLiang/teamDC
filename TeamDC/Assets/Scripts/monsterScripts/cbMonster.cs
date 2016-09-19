using UnityEngine;
using System.Collections;

public class cbMonster : MonoBehaviour {

	public GameObject P1;
	public GameObject P2;
	public float speed;

	// Use this for initialization
	void Start () {
		speed = 10f;
		P1 = GameObject.Find("P1");
		P2 = GameObject.Find("P2");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector3 directionToUnlocker = P1.transform.position - transform.position;
		float uAngle = Vector3.Angle(transform.forward, directionToUnlocker);

		if(uAngle < 180){
			Ray enemyRay = new Ray(transform.position, directionToUnlocker);
			RaycastHit enemyRayInfo = new RaycastHit();

			//Debug.DrawRay(transform.position, directionToUnlocker);


			if(Physics.Raycast(enemyRay, out enemyRayInfo, 100f)){

				if(enemyRayInfo.collider.name == "P1"){
					//Debug.Log(enemyRayInfo.distance);

					if(enemyRayInfo.distance <= 41){
						Debug.Log("Chase it!");

						//GetComponent<Rigidbody>().AddForce(directionToUnlocker.normalized * 10f);
						transform.position = Vector3.MoveTowards(transform.position, P1.transform.position, speed * Time.deltaTime);

					}

				
				}

			}
		}
		
	}
}
