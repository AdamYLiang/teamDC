using UnityEngine;
using System.Collections;

public class DoorTestDoorErik : MonoBehaviour {
    public bool Unlocking = false;
    private int codeCorrect = 0;

    private float codeAnswere1;
    private float codeAnswere2;
    private float codeAnswere3;
    private float codeAnswere4;
    //private float codeAnswere5;
    //private float codeAnswere6;
    //private float codeAnswere7;

    public KeyCode codeAnswereType1;
    public KeyCode codeAnswereType2;
    public KeyCode codeAnswereType3;
    public KeyCode codeAnswereType4;
    //public KeyCode codeAnswereType5;
    //public KeyCode codeAnswereType6;
    //public KeyCode codeAnswereType7;

    // Use this for initialization
    void Start () {

        codeAnswere1 = Random.Range(0f, 1.0f);
        codeAnswere2 = Random.Range(0f, 1.0f);
        codeAnswere3 = Random.Range(0f, 1.0f);
        codeAnswere4 = Random.Range(0f, 1.0f);
        //codeAnswere5 = Random.Range(0, 1);
        //codeAnswere6 = Random.Range(0, 1);
        //codeAnswere7 = Random.Range(0, 1);

        //Debug.Log("The randomed values are " + codeAnswere1 + " and " + codeAnswere2 + " " + codeAnswere3);

        if (codeAnswere1 < .25f) { codeAnswereType1 = KeyCode.Q; }
        if (codeAnswere1 < .50f && codeAnswere1 > .25f) { codeAnswereType1 = KeyCode.W; }
        if (codeAnswere1 < .75f && codeAnswere1 > .50f) { codeAnswereType1 = KeyCode.E; }
        if (codeAnswere1 > .75f) { codeAnswereType1 = KeyCode.R; }

        if (codeAnswere2 < .25f) { codeAnswereType2 = KeyCode.Q; }
        if (codeAnswere2 < .50f && codeAnswere2 > .25f) { codeAnswereType2 = KeyCode.W; }
        if (codeAnswere2 < .75f && codeAnswere2 > .50f) { codeAnswereType2 = KeyCode.E; }
        if (codeAnswere2 > .75f) { codeAnswereType2 = KeyCode.R; }

        if (codeAnswere3 < .25f) { codeAnswereType3 = KeyCode.Q; }
        if (codeAnswere3 < .50f && codeAnswere3 > .25f) { codeAnswereType3 = KeyCode.W; }
        if (codeAnswere3 < .75f && codeAnswere3 > .50f) { codeAnswereType3 = KeyCode.E; }
        if (codeAnswere3 > .75f) { codeAnswereType3 = KeyCode.R; }

        if (codeAnswere4 < .25f) { codeAnswereType4 = KeyCode.Q; }
        if (codeAnswere4 < .50f && codeAnswere4 > .25f) { codeAnswereType4 = KeyCode.W; }
        if (codeAnswere4 < .75f && codeAnswere4 > .50f) { codeAnswereType4 = KeyCode.E; }
        if (codeAnswere4 > .75f) { codeAnswereType4 = KeyCode.R; }
    }
	
	// Update is called once per frame
	void Update () {
        //processes while "unlocking"
        if(Unlocking == true)
        {
            if (Input.GetKeyDown(codeAnswereType1) && codeCorrect == 0)
            {
                Debug.Log("First one complete");
                codeCorrect = 1;
            }
            else if (Input.GetKeyDown(codeAnswereType2) && codeCorrect == 1)
            {
                Debug.Log("Second Complete");
                codeCorrect = 2;
            }
            else if (Input.GetKeyDown(codeAnswereType3) && codeCorrect == 2)
            {
                Debug.Log("Third done");
                codeCorrect = 3;
            }
            else if (Input.GetKeyDown(codeAnswereType4) && codeCorrect ==3)
            {
                 Debug.Log("Unlocked");
                Unlocking = false;
                gameObject.SetActive (false);
            }
        }

        //if player dies reset code state and door state to 0
        if (GameObject.Find("player")==null)
        {
            GetComponent<MeshRenderer>().material.color = Color.white;
            Unlocking = false;
            codeCorrect = 0;
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
                Debug.Log(codeAnswereType1);
                Debug.Log(codeAnswereType2);
                Debug.Log(codeAnswereType3);
                Debug.Log(codeAnswereType4);
                GetComponent<MeshRenderer>().material.color = Color.blue;
                Unlocking = true;
            }
        }
    }
    //only on entering the trigger actions, while player is alive
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player" && (GameObject.Find("player").GetComponent<DoorTestPlayerErik>().playerIsAlive = true))
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Hit SPACE to begin Unlocking");
        }
    }
    //apon exiting the trigger actions, set bool to false, restart code
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
