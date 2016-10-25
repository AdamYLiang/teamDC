using UnityEngine;
using System.Collections;

public class KickDaDoor : MonoBehaviour {

    public GameObject meatHead;
    public Transform whereMeatHead;
    Rigidbody doorBody;
    public float doorSpeed;
    public bool isMeatHeadInFront;
    public bool isMeatHeadBehind;
    // Use this for initialization
    void Start () {
        doorBody = gameObject.GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
        whereMeatHead = meatHead.transform;
        Vector3 tomeatHead = (whereMeatHead.position - transform.position).normalized;

        if (Vector3.Dot(tomeatHead, transform.forward)>0)
        {
            Debug.Log("meathead is in front of door");
            isMeatHeadInFront = true;
            isMeatHeadBehind = false;
        }
        else
        {
            Debug.Log("meathead is behind door");
            isMeatHeadInFront = false;
            isMeatHeadBehind = true;
        }
	
	}

    void OnTriggerStay(Collider other)
    {
        //while this door is stationary it will sense when "meathead" is standing by it.
        if (this.gameObject.tag == ("stationary"))
        {
            Debug.Log("the door is stationary");

            if (other.gameObject == meatHead)
            {
                Debug.Log("meathead is here");
                //meathead can then hit the door to send it flying ("moving").
                if (Input.GetButtonDown("CamoGreen"))
                {
                    if (isMeatHeadInFront == true)
                    {
                        doorBody.AddForce(transform.forward * -doorSpeed);
                        Debug.Log("Door is moving");
                        gameObject.tag = ("moving");
                    }
                    else if (isMeatHeadBehind == true)
                    {
                        doorBody.AddForce(transform.forward * doorSpeed);
                        Debug.Log("Door is moving");
                        gameObject.tag = ("moving");
                    }
                }
            }
            
        }
    }
    void OnTriggerEnter(Collider other)
    {
        //if this door is hit by another moving door it will start moving.
        if (other.gameObject.tag == ("moving"))
        {
            Debug.Log("Door is moving");
            gameObject.tag = ("moving");
            this.doorBody.AddForce(transform.forward * doorSpeed);
            
        }

        //while this door is moving it will "reverse" when it collides with "meathead",
        if (this.gameObject.tag == ("moving"))
        {
            if (other.gameObject == meatHead)
            {
                Debug.Log("reverse door");
                if (isMeatHeadInFront == true)
                {
                    doorBody.AddForce(transform.forward * -2*doorSpeed);
                    Debug.Log("Door is moving");
                    gameObject.tag = ("moving");
                }
                else if (isMeatHeadBehind == true)
                {
                    doorBody.AddForce(transform.forward * 2*doorSpeed);
                    Debug.Log("Door is moving");
                    gameObject.tag = ("moving");
                }
            }
            //the door will destroy "enemies". (can probably keep this script on enemies themselves)
            if (other.gameObject.tag == ("enemy"))
            {
                Debug.Log("door crushes enemy");
                Destroy(other.gameObject);
            }
            if (other.gameObject.name == ("1x1MazeWall"))
            {
                Debug.Log("door crushes enemy");
                Destroy(this.gameObject);
            }
        }
    }
}
