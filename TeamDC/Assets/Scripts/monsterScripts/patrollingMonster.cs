using UnityEngine;
using System.Collections;


/*
* This script is for a patrolling enemy who turns around when it reaches an obstacle. 
*/

public class patrollingMonster : MonoBehaviour {


    
    [SerializeField]
    float speed = 10f; //speed of enemy movement
    [SerializeField]
    float raycastDistance = 3f;

	void Update () {

        transform.position += Vector3.forward * speed  * Time.deltaTime; //makes enemy move


        Ray ray = new Ray(transform.position, transform.forward);
        //Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.red);
        RaycastHit rayHitInfo = new RaycastHit();
        
        if (Physics.Raycast(ray, out rayHitInfo, raycastDistance)) //when the raycast hits something
        {
            transform.Rotate(0f, 180f, 0f);  //turn around and reverse speed (so it goes in the opposite direction
            speed *= -1;
        }
	}
}
