using UnityEngine;
using System.Collections;

public class complicatedSwitch : MonoBehaviour {

    public GameObject switch1;
    public GameObject switch2;
    public GameObject switch3;
    public GameObject switchdoor1;
    public GameObject switchdoor2;
    public GameObject switchdoor3;

    public bool switch1Pressed = false;
    public bool switch2Pressed = false;
    public bool switch3Pressed = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (switch1Pressed && switch2Pressed && switch3Pressed)
        {
            switchdoor1.SetActive(false);
            switchdoor2.SetActive(false);
            switchdoor3.SetActive(false);
        }
	}

    void OnTriggerStay(Collider activator) {
        if (activator.tag == "Player" || activator.tag == "attacker")
        {

        }
    }
}
