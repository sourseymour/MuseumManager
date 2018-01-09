﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransC1 : MonoBehaviour {
	public Transform target;
	public float speed;

	public static bool TransC1sw = false;


	void Update() {
		if (TransC1sw == true) {
			Vector3 dir = target.position - transform.position;
			transform.Translate (dir.normalized * speed * Time.deltaTime, Space.World);

			if (Vector3.Distance (transform.position, target.position) <= 0.1f) {
				speed = 0;
			}
			//float step = speed * Time.deltaTime;
			//transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		}
	}


} 