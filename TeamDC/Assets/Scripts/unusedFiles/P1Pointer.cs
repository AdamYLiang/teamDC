using UnityEngine;
using System.Collections;

public class P1Pointer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var target = GameObject.FindWithTag("player2");

        transform.LookAt(target.transform);

        MeshRenderer armRenderer = GameObject.Find("arm1").GetComponent<MeshRenderer>();
        BoxCollider armCollider = GameObject.Find("arm1").GetComponent<BoxCollider>();
        armRenderer.enabled = false;
        armCollider.enabled = false;
        if (Input.GetKey(KeyCode.Space)&&Input.GetKey(KeyCode.B))
        {
            armRenderer.enabled = true;
            armCollider.enabled = true;
        }

    }
    void OnEnterTrigger(Collider other)
    {
        if (other.gameObject.tag == "enemy")
        {
            other.gameObject.GetComponent<DoorTestEnemyErik>().enemyWalk = 0;
        }
    }
}
