using UnityEngine;
using System.Collections;

public class reciverTestFlyingDoor : MonoBehaviour {

    public float speed = 1000f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider activator)
    {
        if (activator.tag == "flyingdoor")
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
    }
}


