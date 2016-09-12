using UnityEngine;
using System.Collections;

public class MonsterController : MonoBehaviour {

	public float attackTimer;
	public int pattern;
	public bool attackNotCD;

	// Use this for initialization
	void Start () {
		attackTimer = 3.0f;
		pattern = 0;
		attackNotCD = true;
		//0 = red
		//1 = blue
		//2 = green
		//3 = yellow
	}
	
	// Update is called once per frame
	void Update () {
		
		float rnGen = Random.Range(0f,1f);

		//if(Input.GetKeyDown(KeyCode.R)){
		//	this.GetComponent<Renderer>().material.color = Color.blue;
		//}

		if(attackTimer > 0){

			attackTimer -= Time.deltaTime;

		}

		if(attackTimer <= 0.5f && attackTimer > 0){
			this.GetComponent<Renderer>().material.color = Color.red;
		}

		//Debug.Log("Attack pattern is " + pattern);

		if(attackTimer <= 0){

			if(rnGen <= 0.4){
				pattern = 1;
			}

			else if(rnGen > 0.4 && rnGen <= 0.6){
				pattern = 2;
			}

			else if(rnGen > 0.6){
				pattern = 3;
			}

			switch(pattern){
				case 1:
					//Debug.Log(1);
					this.GetComponent<Renderer>().material.color = Color.blue;
					break;
				case 2:
					//Debug.Log(2);
					this.GetComponent<Renderer>().material.color = Color.green;
					break;
				case 3:
					//Debug.Log(3);
					this.GetComponent<Renderer>().material.color = Color.yellow;
					break;
			}

			//this.GetComponent<Renderer>().material.color = Color.blue;

			attackNotCD = true;
			attackTimer = 3.0f;
		}

		//Debug.Log("test");
		//Debug.Log(attackTimer);
	
	}
}
