using UnityEngine;
using System.Collections;

public class p2Spawn : MonoBehaviour {

	public GameObject P2;

	void Start(){
		P2 = GameObject.Find("MainP");
	}

	void OnTriggerEnter(Collider activator){
		P2.GetComponent<mainPlayerMovement>().canSpawnP2 = true;
		Destroy(this.gameObject);
	}
}
