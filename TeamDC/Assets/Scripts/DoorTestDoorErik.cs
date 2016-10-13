using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DoorTestDoorErik : MonoBehaviour {

	//TODO:
	//Refactor some code here
	//Figure out the error code
	//Hook it up to a controller 
	//Refactor code to be a loop instead of if statements

    //sees if player is attempting to unlock door
	public bool unlocking;

    //test for correct code
    private int codeCorrect = 0;


	public Text unlockText; 	//Text to show up when unlocking

	//Text to show player what they should actually input 
	public string actualInput1;
	public string actualInput2; 
	public string actualInput3;
	public string actualInput4; 

    //random number variables
    private float codeAnswere1;
    private float codeAnswere2;
    private float codeAnswere3;
    private float codeAnswere4;
    //private float codeAnswere5;
    //private float codeAnswere6;
    //private float codeAnswere7;

	public string codeAnswereType1;
	public string codeAnswereType2;
	public string codeAnswereType3;
	public string codeAnswereType4;
	public int codeType1;
	public int codeType2;
	public int codeType3;
	public int codeType4;

    // Use this for initialization
    void Start () {

		unlockText = GameObject.Find("UnlockText").GetComponent<Text>();

        //creates random number to later decide random code
		unlocking = false;
        codeAnswere1 = Random.Range(0f, 1.0f);
        codeAnswere2 = Random.Range(0f, 1.0f);
        codeAnswere3 = Random.Range(0f, 1.0f);
        codeAnswere4 = Random.Range(0f, 1.0f);
        //codeAnswere5 = Random.Range(0, 1);
        //codeAnswere6 = Random.Range(0, 1);
        //codeAnswere7 = Random.Range(0, 1);

        //Debug.Log("The randomed values are " + codeAnswere1 + " and " + codeAnswere2 + " " + codeAnswere3)

		//If statement sets whether it is horizontal or vertical axis
		//Then checks if you have to press up or down
		//Then assigns string value of what the correct button is 
		if (codeAnswere1 < .25f) { 
			codeAnswereType1 = "Door Horizontal";
			codeType1 = 1;
			actualInput1 = "Right";}
		if (codeAnswere1 < .50f && codeAnswere1 > .25f) { 
			codeAnswereType1 = "Door Horizontal";
			codeType1 = -1;
			actualInput1 = "Left";}
		if (codeAnswere1 < .75f && codeAnswere1 > .50f) { 
			codeAnswereType1 = "Door Vertical";
			codeType1 = 1;
			actualInput1 = "Up";}
		if (codeAnswere1 > .75f) { 
			codeAnswereType1 = "Door Vertical";
			codeType1 = -1;
			actualInput1 = "Down";}

		if (codeAnswere2 < .25f) { 
			codeAnswereType2 = "Door Horizontal";
			codeType2 = 1;
			actualInput2 = "Right";}
		if (codeAnswere2 < .50f && codeAnswere2 > .25f) { 
			codeAnswereType2 = "Door Horizontal";
			codeType2 = -1;
			actualInput2 = "Left";}
		if (codeAnswere2 < .75f && codeAnswere2 > .50f) { 
			codeAnswereType2 = "Door Vertical";
			codeType2 = 1;
			actualInput2 = "Up";}
		if (codeAnswere2 > .75f) { 
			codeAnswereType2 = "Door Vertical";
			codeType2 = -1;
			actualInput2 = "Down";}

		if (codeAnswere3 < .25f) { 
			codeAnswereType3 = "Door Horizontal";
			codeType3= 1;
			actualInput3 = "Right";}
		if (codeAnswere3 < .50f && codeAnswere3 > .25f) { 
			codeAnswereType3 = "Door Horizontal";
			codeType3 = -1;
			actualInput3 = "Left";}
		if (codeAnswere3 < .75f && codeAnswere3 > .50f) { 
			codeAnswereType3 = "Door Vertical";
			codeType3 = 1;
			actualInput3 = "Up";}
		if (codeAnswere3 > .75f) { 
			codeAnswereType3 = "Door Vertical";
			codeType3 = -1;
			actualInput3 = "Down";}

		if (codeAnswere4 < .25f) { 
			codeAnswereType4 = "Door Horizontal";
			codeType4 = 1;
			actualInput4 = "Right";}
		if (codeAnswere4 < .50f && codeAnswere4 > .25f) { 
			codeAnswereType4 = "Door Horizontal";
			codeType4 = -1;
			actualInput4 = "Left";}
		if (codeAnswere4 < .75f && codeAnswere4 > .50f) { 
			codeAnswereType4 = "Door Vertical"; 
			codeType4 = 1;
			actualInput4 = "Up";}
		if (codeAnswere4 > .75f) { 
			codeAnswereType4 = "Door Vertical"; 
			codeType4 = -1;
			actualInput4 = "Down";}
    }
	
	// Update is called once per frame
	void Update () {

		//Debug.Log("updating doors");

        //processes while "unlocking"
        if(unlocking == true)
        {
			//Debug.Log("WOOWOWOWOOW");
            //if the first key code is entered

			if ((Input.GetAxis(codeAnswereType1) == codeType1) && codeCorrect == 0)
            {
				unlockText.text = "Code is: " + actualInput2;
                Debug.Log("First one complete");
                codeCorrect = 1;
            }
            //if second key code two entered
			else if ((Input.GetAxis(codeAnswereType2) == codeType2) && codeCorrect == 1)
            {
				unlockText.text = "Code is: " + actualInput3;
                Debug.Log("Second Complete");
                codeCorrect = 2;
            }
            //if key code three entered
			else if ((Input.GetAxis(codeAnswereType3) == codeType3) && codeCorrect == 2)
            {
				unlockText.text = "Code is: " + actualInput4;
                Debug.Log("Third done");
                codeCorrect = 3;
            }
            //if fourth key code entered
			else if ((Input.GetAxis(codeAnswereType4) == codeType4) && codeCorrect ==3)
            {
                 Debug.Log("Unlocked");
                unlocking = false;
				unlockText.text = "";
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
    void OnTriggerEnter(Collider other)
    {
		//If unlocker begins to unlock, change to first code and start.
		if (other.gameObject.name == "P1")
		{
			unlockText.text = "Hit LT to Unlock";
			GetComponent<MeshRenderer>().material.color = Color.red;
			//Debug.Log("Hit SPACE to begin Unlocking");
		}

    }
    //only on entering the trigger actions, while player is alive
    void OnTriggerStay(Collider other)
    {
		//If the unlocker is inside, update the UI with text 
		if (other.gameObject.name == "P1")
		{
			if (Input.GetKeyDown(KeyCode.Space) || (Input.GetAxis("unlockAbility") == 1))
			{
				Debug.Log("Unlocking");
				//				Debug.Log("The 1st code is " + codeAnswereType1 + " inputting " + codeType1);
				//				Debug.Log("The 2nd code is " + codeAnswereType2 + " inputting " + codeType2);
				//				Debug.Log("The 3rd code is " + codeAnswereType3 + " inputting " + codeType3);
				//				Debug.Log("The 4th code is " + codeAnswereType4 + " inputting " + codeType4);
				GetComponent<MeshRenderer>().material.color = Color.blue;
				unlockText.text = "Code is: " + actualInput1;
				unlocking = true;
			}
		}
    }
    //apon exiting the trigger actions, set bool to false, restart code
    void OnTriggerExit(Collider other)
    {
		//If unlocker leaves reset 
        if (other.gameObject.name == "P1")
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            unlocking = false;
            codeCorrect = 0;
			unlockText.text = "";
        }
    }
}
