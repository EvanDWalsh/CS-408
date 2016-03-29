/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using System.Collections;

public class LoginRegisterScript : MonoBehaviour {

	public static string username = "NotSet";
	private string password;

	public void setUsername(string user) {
		username = user;
	}

	public void setPassword(string pass) {
		this.password = pass;
	}
	
	public void loginClicked() {
		// TODO: Login Validation/Check
		if(username=="NotSet" || username=="") { return; }

		Debug.Log("Login Clicked: "+username+", "+password);
		SceneManager.LoadScene("HomeScene");
	}

	public void registerClicked() {
		// TODO: Register Submission/Validation
		if(username=="NotSet" || username=="") { return; }

		Debug.Log("Register Clicked: "+username+", "+password);
		SceneManager.LoadScene("HomeScene");
	}
}
