using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("right"))
			Move(1);
		if(Input.GetKeyDown("left"))
			Move(2);
		if(Input.GetKeyDown("up"))
			Move(0);
		if(Input.GetKeyDown("down"))
			Move(3);
	}

	/*
	0: up
	1: right
	2: left
	3: down
	
	*/
	void Move (int direction) {
		
		switch(direction) {
			case 0: 
				gameObject.transform.position = gameObject.transform.position + new Vector3(0,1,0); 
				break;
			case 1: 
				gameObject.transform.position = gameObject.transform.position + new Vector3(1,0,0);
				break;
			case 2: 
				gameObject.transform.position = gameObject.transform.position + new Vector3(-1,0,0);
				break;
			case 3: 
				gameObject.transform.position = gameObject.transform.position + new Vector3(0,-1,0);
				break;
		}
	}
}


