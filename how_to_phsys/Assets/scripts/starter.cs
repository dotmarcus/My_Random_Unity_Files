﻿using UnityEngine;
using System.Collections;

public class starter : MonoBehaviour {

	public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey (KeyCode.Space))
		{
			transform.position -= transform.right * Time.deltaTime * moveSpeed;
		}
	}
}
