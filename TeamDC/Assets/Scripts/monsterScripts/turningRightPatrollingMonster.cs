using UnityEngine;
using System.Collections;

public class turningRightPatrollingMonster : MonoBehaviour {


    [SerializeField]
    float speed = 2500f; //speed of enemy movement
    [SerializeField]
    float raycastDistance = 3f;
    [SerializeField]
    bool isTurnt = false;
    public LayerMask layerM;
	public bool turnRight; //initialize in inspector, DO NOT TICK BOTH
	public bool turnLeft;
  

    void Start ()
    {
        layerM = (1 << 9);
        layerM = ~layerM;
		//speed = 2500;
    }

    void FixedUpdate()
    {
        //check what collor light is on

		if(turnRight){
        GetComponent<Rigidbody>().velocity = transform.forward * speed * Time.deltaTime; //makes enemy move

        Ray ray = new Ray(transform.position, transform.forward);
       // Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.red);
        RaycastHit rayHitInfo = new RaycastHit();

        if (Physics.Raycast(ray, out rayHitInfo, raycastDistance, layerM)) //when the raycast hits something
        {
            transform.Rotate(0f, 90f, 0f);
        }
		}

		if(turnLeft){
			GetComponent<Rigidbody>().velocity = transform.forward * speed * Time.deltaTime; //makes enemy move

			Ray ray = new Ray(transform.position, transform.forward);
			//Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.red);
			RaycastHit rayHitInfo = new RaycastHit();

			if (Physics.Raycast(ray, out rayHitInfo, raycastDistance)) //when the raycast hits something
			{
				transform.Rotate(0f, -90f, 0f);
			}
		}
    }
}
