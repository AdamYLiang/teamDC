using UnityEngine;
using System.Collections;

public class P2Pointer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {

        var target = GameObject.FindWithTag("player1");

        transform.LookAt(target.transform);

        MeshRenderer armRenderer = GameObject.Find("arm2").GetComponent<MeshRenderer>();
        BoxCollider armCollider = GameObject.Find("arm2").GetComponent<BoxCollider>();
        armRenderer.enabled = false;
        armCollider.enabled = false;
        if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.B))
        {
            armRenderer.enabled = true;
            armCollider.enabled = true;
        }

    }
}
