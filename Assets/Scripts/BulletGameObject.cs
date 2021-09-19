﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGameObject : MonoBehaviour {
    public float speed = 10; 
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed; 
	}

	// Update is called once per frame
	private void OnBecameInvisible ()
    {
        Destroy(gameObject); 
	}
}
