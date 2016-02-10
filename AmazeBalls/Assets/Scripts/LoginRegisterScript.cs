﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class LoginRegisterScript : MonoBehaviour {

	private string username;
	private string password;

	// Use this for initialization
	void Start () {
	
	}

	public void setUsername(string user) {
		this.username = user;
	}

	public void setPassword(string pass) {
		this.password = pass;
	}
	
	public void loginClicked() {
		// TODO: Login Validation/Check

		Debug.Log("Login Clicked: "+username+", "+password);
		Application.LoadLevel("HomeScene");
	}

	public void registerClicked() {
		// TODO: Register Submission/Validation

		Debug.Log("Register Clicked: "+username+", "+password);
		Application.LoadLevel("HomeScene");
	}
}
