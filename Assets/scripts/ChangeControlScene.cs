﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeControlScene : MonoBehaviour {
	public string levelToLoad;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			SceneManager.LoadScene ("controls_scene");
		}
	}
}
