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
		
		Collider2D hitCollider;
		
		
		switch(direction) {
			case 0: 
				hitCollider = Physics2D.OverlapCircle(gameObject.transform.position + new Vector3(0,1,0), 0.2f);
				if (!hitCollider) {
					gameObject.transform.position = gameObject.transform.position + new Vector3(0,1,0); 
				}
				else {
					
				}
				break;
			case 1: 
				hitCollider = Physics2D.OverlapCircle(gameObject.transform.position + new Vector3(1,0,0), 0.2f);
				if (!hitCollider) {
					gameObject.transform.position = gameObject.transform.position + new Vector3(1,0,0);
				}
				else {
					
				}
				break;
			case 2: 
				hitCollider = Physics2D.OverlapCircle(gameObject.transform.position + new Vector3(-1,0,0), 0.2f);
				if (!hitCollider) {
					gameObject.transform.position = gameObject.transform.position + new Vector3(-1,0,0);
				}
				else {
					
				}
				break;
			case 3: 
				hitCollider = Physics2D.OverlapCircle(gameObject.transform.position + new Vector3(0,-1,0), 0.2f);
				if (!hitCollider) {
					gameObject.transform.position = gameObject.transform.position + new Vector3(0,-1,0);
				}
				else {
					
				}
				break;
		}
	}
}


