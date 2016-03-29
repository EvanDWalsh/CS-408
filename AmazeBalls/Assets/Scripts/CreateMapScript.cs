/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreateMapScript : MonoBehaviour {
	
	public void backClicked() {
		SceneManager.LoadScene("HomeScene");
	}
}
