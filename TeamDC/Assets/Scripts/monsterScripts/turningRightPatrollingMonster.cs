using UnityEngine;
using System.Collections;

public class turningRightPatrollingMonster : MonoBehaviour {


    [SerializeField]
    float speed = 500f; //speed of enemy movement
    [SerializeField]
    float raycastDistance = 3f;
    [SerializeField]
    bool isTurnt = false;
    public LayerMask layerM;

    void Start ()
    {
        layerM = (1 << 9);
        layerM = ~layerM;
    }

    void Update()
    {

        GetComponent<Rigidbody>().velocity = transform.forward * speed * Time.deltaTime; //makes enemy move

        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.red);
        RaycastHit rayHitInfo = new RaycastHit();

        if (Physics.Raycast(ray, out rayHitInfo, raycastDistance, layerM)) //when the raycast hits something
        {
            transform.Rotate(0f, 90f, 0f);
        }
    }
}
