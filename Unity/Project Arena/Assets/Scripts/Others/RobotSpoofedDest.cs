﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotSpoofedDest : MonoBehaviour {

    public GameObject robot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            robot.GetComponent<Robot>().SetTempReached();
            Debug.Log("An agent has reached my position");
        }
    }
}