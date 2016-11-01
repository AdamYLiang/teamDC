using UnityEngine;
using System.Collections;

public class DoorFrame : MonoBehaviour {
    Vector3 doorPosition;
    Vector3 framePosition;
    Vector3 distanceDoor;
    bool testingBool = false;
    //bool direction;
    GameObject lerpingObject;
    float t;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if (testingBool)
        {
            
            if(t<=1)
            {
                //direction = false;
            //}
            //if(!direction)
            //{
                t += .03f;
            }
            
            lerpingObject.transform.position = Vector3.Lerp(doorPosition, framePosition, t);
           
        }

	}
    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == ("moving"))
        {
            Debug.Log("door in frame");
            

            doorPosition = other.GetComponent<Transform>().position;
            framePosition = this.gameObject.transform.position;

            if (Mathf.Abs(doorPosition.magnitude - framePosition.magnitude) < 1)
            {
                Debug.Log("door frame stop");
                testingBool = true;
                lerpingObject = other.gameObject;
                other.GetComponent<KickDaDoor>().doorBody.velocity = new Vector3(0, 0, 0);
                t = 0f; 
            }
        }
    }
}
