﻿using UnityEngine;
using System.Collections;

public class DoorTestDoorErik : MonoBehaviour {

	//TODO:
	//Refactor some code here
	//Figure out the error code
	//Hook it up to a controller 

    //sees if player is attempting to unlock door
	public bool unlocking;

    //test for correct code
    private int codeCorrect = 0;

    //random number variables
    private float codeAnswere1;
    private float codeAnswere2;
    private float codeAnswere3;
    private float codeAnswere4;
    //private float codeAnswere5;
    //private float codeAnswere6;
    //private float codeAnswere7;

    //keycodes for random keycodes
    public KeyCode codeAnswereType1;
    public KeyCode codeAnswereType2;
    public KeyCode codeAnswereType3;
    public KeyCode codeAnswereType4;
    //public KeyCode codeAnswereType5;
    //public KeyCode codeAnswereType6;
    //public KeyCode codeAnswereType7;

    // Use this for initialization
    void Start () {

        //creates random number to later decide random code
		unlocking = false;
        codeAnswere1 = Random.Range(0f, 1.0f);
        codeAnswere2 = Random.Range(0f, 1.0f);
        codeAnswere3 = Random.Range(0f, 1.0f);
        codeAnswere4 = Random.Range(0f, 1.0f);
        //codeAnswere5 = Random.Range(0, 1);
        //codeAnswere6 = Random.Range(0, 1);
        //codeAnswere7 = Random.Range(0, 1);

        //Debug.Log("The randomed values are " + codeAnswere1 + " and " + codeAnswere2 + " " + codeAnswere3);

        //selects the random code based on the random numbers
		if (codeAnswere1 < .25f) { codeAnswereType1 = KeyCode.Alpha1; }
		if (codeAnswere1 < .50f && codeAnswere1 > .25f) { codeAnswereType1 = KeyCode.Alpha2; }
		if (codeAnswere1 < .75f && codeAnswere1 > .50f) { codeAnswereType1 = KeyCode.Alpha3; }
		if (codeAnswere1 > .75f) { codeAnswereType1 = KeyCode.Alpha4; }

        if (codeAnswere2 < .25f) { codeAnswereType2 = KeyCode.Alpha1; }
		if (codeAnswere2 < .50f && codeAnswere2 > .25f) { codeAnswereType2 = KeyCode.Alpha2; }
		if (codeAnswere2 < .75f && codeAnswere2 > .50f) { codeAnswereType2 = KeyCode.Alpha3; }
		if (codeAnswere2 > .75f) { codeAnswereType2 = KeyCode.Alpha4; }

        if (codeAnswere3 < .25f) { codeAnswereType3 = KeyCode.Alpha1; }
		if (codeAnswere3 < .50f && codeAnswere3 > .25f) { codeAnswereType3 = KeyCode.Alpha2; }
		if (codeAnswere3 < .75f && codeAnswere3 > .50f) { codeAnswereType3 = KeyCode.Alpha3; }
		if (codeAnswere3 > .75f) { codeAnswereType3 = KeyCode.Alpha4; }

        if (codeAnswere4 < .25f) { codeAnswereType4 = KeyCode.Alpha1; }
		if (codeAnswere4 < .50f && codeAnswere4 > .25f) { codeAnswereType4 = KeyCode.Alpha2; }
		if (codeAnswere4 < .75f && codeAnswere4 > .50f) { codeAnswereType4 = KeyCode.Alpha3; }
		if (codeAnswere4 > .75f) { codeAnswereType4 = KeyCode.Alpha4; }
    }
	
	// Update is called once per frame
	void Update () {
        
		//Debug.Log("updating doors");

        //processes while "unlocking"
        if(unlocking == true)
        {
			//Debug.Log("WOOWOWOWOOW");
            //if the first key code is entered
            if (Input.GetKeyDown(codeAnswereType1) && codeCorrect == 0)
            {
                Debug.Log("First one complete");
                codeCorrect = 1;
            }
            //if second key code two entered
            else if (Input.GetKeyDown(codeAnswereType2) && codeCorrect == 1)
            {
                Debug.Log("Second Complete");
                codeCorrect = 2;
            }
            //if key code three entered
            else if (Input.GetKeyDown(codeAnswereType3) && codeCorrect == 2)
            {
                Debug.Log("Third done");
                codeCorrect = 3;
            }
            //if fourth key code entered
            else if (Input.GetKeyDown(codeAnswereType4) && codeCorrect ==3)
            {
                 Debug.Log("Unlocked");
                unlocking = false;
                gameObject.SetActive (false);
            }
        }

        //if player dies reset code state and door state to 0
//        if (GameObject.Find("player")==null)
//        {
//            GetComponent<MeshRenderer>().material.color = Color.white;
//            unlocking = false;
//            codeCorrect = 0;
//        }


    }

    //While triggering the door actions, entering "unlocking"
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "P1")
        {

			if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire2"))
            {
                Debug.Log("Unlocking");
                Debug.Log(codeAnswereType1);
                Debug.Log(codeAnswereType2);
                Debug.Log(codeAnswereType3);
                Debug.Log(codeAnswereType4);
                GetComponent<MeshRenderer>().material.color = Color.blue;
                unlocking = true;
            }
        }
    }
    //only on entering the trigger actions, while player is alive
    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.name == "P1")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Hit SPACE to begin Unlocking");
        }
    }
    //apon exiting the trigger actions, set bool to false, restart code
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "P1")
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            unlocking = false;
            codeCorrect = 0;
        }
    }
}
