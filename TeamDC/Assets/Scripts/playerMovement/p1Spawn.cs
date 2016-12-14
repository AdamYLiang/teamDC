using UnityEngine;
using System.Collections;

public class p1Spawn : MonoBehaviour {

	public GameObject P1;

	void Start(){
		P1 = GameObject.Find("MainP");
	}

	void OnTriggerEnter(Collider activator){
		P1.GetComponent<mainPlayerMovement>().canSpawnP1 = true;
		Destroy(this.gameObject);
	}
}
