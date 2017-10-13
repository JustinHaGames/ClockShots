﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	float timer; 
	float mxTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject gun = GameObject.Find ("Gun");
		Gun gunscript = gun.GetComponent<Gun> ();

		timer += Time.deltaTime;

		switch (gunscript.bulletCount) {
		case 6: 
			mxTime = 1f; 
			break; 
		case 5:
			mxTime = 1.5f; 
			break;
		case 4:
			mxTime = 2.4f; 
			break;
		case 3: 
			mxTime = 4.3f; 
			break;
		case 2: 
			mxTime = 6.5f; 
			break;
		case 1: 
			mxTime = 9.3f; 
			break;
		case 0:
			mxTime = 12.1f; 
			break;
		}

		if (timer > mxTime) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Bullet") {
			Destroy(gameObject); 
		}
	}
}
