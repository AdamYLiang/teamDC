﻿using UnityEngine;
using System.Collections;

public class DoorTestPlayerErik : MonoBehaviour {
    public float moveSpeed;
    public bool playerIsAlive = true;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        //Baisic movment of player object
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(-1f*(Time.deltaTime*moveSpeed), 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(1f * (Time.deltaTime * moveSpeed), 0f, 0f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0f, 0f, 1f * (Time.deltaTime * moveSpeed));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0f, 0f, -1f * (Time.deltaTime * moveSpeed));
        }

    }
    void OnTriggerEnter(Collider other)
    {
        //actions while player is near enemy

        if (other.gameObject.tag == "enemy")
        {
            Debug.Log("Player attacked by enemy");

            playerIsAlive = false;

            Destroy(gameObject);
        }
    }
}
