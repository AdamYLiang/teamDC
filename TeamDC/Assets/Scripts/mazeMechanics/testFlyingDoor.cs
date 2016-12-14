using UnityEngine;
using System.Collections;

public class testFlyingDoor : MonoBehaviour
{

    public float speed = 500;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);

        }
    }
}

