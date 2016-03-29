﻿/*
-- A-Maze-Balls: Purdue CS 408
-- https://github.com/EvanDWalsh/CS-408
-- Spring 2016
*/

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelSelectionScript : MonoBehaviour {
	public static int levelsUnlocked = -1;

	public static void unlockLevel(int level) {
		//levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 0); // Get LevelsUnlocked
		level++; // 0 indexed to 1 indexed

		//if(levelsUnlocked < level) {
			levelsUnlocked = level;
			PlayerPrefs.SetInt("levelsUnlocked",levelsUnlocked);
			PlayerPrefs.Save(); // Save LevelsUnlocked
		//}
	}

	public static void resetUnlocked() {
		levelsUnlocked = 0;
		//PlayerPrefs.SetInt("levelsUnlocked",levelsUnlocked);
		//PlayerPrefs.Save(); // Save LevelsUnlocked
	}

	public int numLevels = 2;
	public GameObject GridOfLevels;
	public GameObject LevelPrefab;

	void Start () {
		if(levelsUnlocked == -1) {
			levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 0); // Get LevelsUnlocked
		}

		int numLevelsToDisplay = levelsUnlocked + 1;
		if(numLevelsToDisplay > numLevels) {
			numLevelsToDisplay = numLevels;
		}
		for(int level=1; level<=numLevelsToDisplay; level++) {
			GameObject newLevel = Instantiate (LevelPrefab);
			newLevel.transform.SetParent(GridOfLevels.transform);
			newLevel.GetComponentsInChildren<Text> ()[0].text = "Level " + (level+1);
			newLevel.name = "Level" + level;
			int localLevel = level;
			newLevel.GetComponent<Button>().onClick.AddListener (delegate { // Add On Click Event
				levelClicked(localLevel);
			});
		}
	}
	
	public void backClicked() {
		SceneManager.LoadScene("LoginScene");
	}

	public void levelClicked(int level) {
		GameControllerScript.currentLevel = level - 1;
		SceneManager.LoadScene("GameScene");
	}
}
