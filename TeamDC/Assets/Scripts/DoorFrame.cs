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
	bool moveDoor;
    

	// Use this for initialization
	void Start () {
		moveDoor = true;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	if (testingBool)
        {
         	
			//If the time is less than this amount increment it and lerp
            if(t<=1f)
            {
                t += .03f;
				lerpingObject.transform.position = Vector3.Lerp(doorPosition, framePosition, t);
            }

			//lerpingObject.transform.position = Vector3.Lerp(doorPosition, framePosition, t);
			//Debug.Log(t);
        }

	}
    void OnTriggerEnter(Collider other)
    {
       //If the door enters is moving or stationary, turn it to stationary and prepare to lerp it to the center
		if (other.gameObject.tag == ("moving") || other.gameObject.tag == "stationary")
        {
           // Debug.Log("door in frame");
			other.gameObject.tag = "stationary";

            doorPosition = other.GetComponent<Transform>().position;
            framePosition = this.gameObject.transform.position;

            if (Mathf.Abs(doorPosition.magnitude - framePosition.magnitude) < 1)
            {
                //Debug.Log("door frame stop");
                testingBool = true;
                lerpingObject = other.gameObject;
                other.GetComponent<KickDaDoor>().doorBody.velocity = new Vector3(0, 0, 0);
                t = 0f; 
            }
        }
    }

	void OnTriggerExit(Collider other){
		//Once the door leaves the trigger, set the door to moving, reset the timer 
		if(other.gameObject.tag == "stationary"){
			moveDoor = true;
			t = 0;
		}
	}

}
