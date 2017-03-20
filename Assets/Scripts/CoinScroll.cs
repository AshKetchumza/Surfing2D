﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScroll : MonoBehaviour {

	public float speed = 0.0005f;

	// Use this for initialization
	void Start () {
		// We don't need anything here right now
	}

	// Update is called once per frame
	void Update () {
		if (GameManager.instance.isPaused == false) {
			//Once spawned, scroll the islands at the same speed as the ocean scroll
			this.transform.Translate (Vector2.up * Time.deltaTime * 2, Camera.main.transform);
		}
	}
}
