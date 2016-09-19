using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	CharacterController myCharController;
	public float speed = 10f;

	// Use this for initialization
	void Start () {
	
		myCharController = GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
	
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 fMovement = transform.forward * speed * vertical;
		myCharController.Move((fMovement + Physics.gravity) * Time.deltaTime);
		Vector3 rMovement = transform.right * speed * horizontal;
		myCharController.Move((rMovement + Physics.gravity) * Time.deltaTime);

	}
}
