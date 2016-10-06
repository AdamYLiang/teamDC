using UnityEngine;
using System.Collections;

public class RadarEffectTest : MonoBehaviour {

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //enemy Radar

           

    }
    void OnEnterTrigger(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {

        }
    }
}
