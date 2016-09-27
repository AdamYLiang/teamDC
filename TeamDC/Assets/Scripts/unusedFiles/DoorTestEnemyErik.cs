using UnityEngine;
using System.Collections;

public class DoorTestEnemyErik : MonoBehaviour {
    public float enemyWalk;
    public float enemyRun;
    Vector3 playerPosition;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

//        playerPosition = GameObject.FindGameObjectWithTag("player").transform.position;
//        transform.LookAt(playerPosition);
//
//        transform.position += transform.forward * enemyWalk * Time.deltaTime;
//
//        //if the player is unlocking a door, how should enemy behave?
//        if ((GameObject.Find("Door").GetComponent<DoorTestDoorErik>().unlocking))
//        {
//            transform.position += transform.forward * enemyRun * Time.deltaTime;
//        }
//            transform.position += transform.forward * enemyWalk * Time.deltaTime;
    }
}
