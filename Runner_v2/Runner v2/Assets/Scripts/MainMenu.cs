using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;
	public string dificultyMenu;

	public void PlayGame(){
		SceneManager.LoadScene(playGameLevel);﻿
	}

	public void ChangeDificulty(){
		PlayerPrefs.SetString ("lastScene", SceneManager.GetActiveScene ().name);
		SceneManager.LoadScene(dificultyMenu);﻿
	}

	public void QuitGame(){
		Application.Quit();
	}

}
