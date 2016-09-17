using UnityEngine;
using System.Collections;

public class DoorTestDoorErik : MonoBehaviour {
    public bool Unlocking = false;
    private int codeCorrect = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //processes while "unlocking"
        if(Unlocking == true)
        {
            if (Input.GetKeyDown(KeyCode.Q) && codeCorrect == 0)
            {
                codeCorrect = 1;
            }
            if (Input.GetKeyDown(KeyCode.W) && codeCorrect == 1)
            {
                codeCorrect = 2;
            }
            if (Input.GetKeyDown(KeyCode.E)&& codeCorrect ==2)
            {
                 Debug.Log("Unlocked");
                Unlocking = false;
                 Destroy(gameObject);
            }
                
        }


    }
    //While triggering the door actions, entering "unlocking"
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Unlocking");
                Debug.Log("Hit the 'Q , W , E' to unlock.");
                GetComponent<MeshRenderer>().material.color = Color.blue;
                Unlocking = true;

            }
        }
    }
    //only on entering the trigger actions
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            //Destroy(gameObject);
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Hit SPACE to begin Unlocking");
        }
    }
    //apon existing the trigger actions, set bool to false, restart code
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Unlocking = false;
            codeCorrect = 0;
        }
    }
}
