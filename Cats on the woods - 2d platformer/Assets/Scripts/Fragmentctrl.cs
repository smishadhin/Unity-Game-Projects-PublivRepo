﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragmentctrl : MonoBehaviour{

	public Vector3 jumpForce;

	public float destroyDelay;

	private Rigidbody2D rb;
	// Use this for initialization
	void Start (){
		rb = GetComponent<Rigidbody2D>();
		rb.AddForce(jumpForce);
		Destroy(gameObject,destroyDelay);
	}
	
	
}
