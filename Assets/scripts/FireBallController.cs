﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallController : MonoBehaviour {

	[Tooltip("Velocidad de moviemiento en unidades del mundo")]
	public float speed;
	GameObject player;
	Rigidbody2D rb2d;
	Vector3 target, dir;

	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		if (player != null) {
			target = player.transform.position;
			dir = (target - transform.position).normalized;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (target != Vector3.zero) {
			rb2d.MovePosition (transform.position + (dir * speed) * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag ("Player")) {
			Destroy (gameObject);
		}
	}

	// Si sale de la pantalla se destruya la fireball.
	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
