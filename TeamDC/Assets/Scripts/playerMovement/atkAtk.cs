using UnityEngine;
using System.Collections;

public class atkAtk : MonoBehaviour {

	void OnTriggerStay(Collider activator){

		if(activator.tag == "enemy"){

			Debug.Log("Attack it!");

			if(Input.GetKeyDown(KeyCode.M)){
				Debug.Log("Kill it with fire");
				Destroy(activator.gameObject);
			}
		}

	}
}
