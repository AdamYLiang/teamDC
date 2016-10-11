using UnityEngine;
using System.Collections;

public class TestErikArm : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnEnterTrigger(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            other.gameObject.GetComponent<DoorTestEnemyErik>().enemyWalk = 0f;
            Debug.Log("arm hit enemy");
        }
    }
}
