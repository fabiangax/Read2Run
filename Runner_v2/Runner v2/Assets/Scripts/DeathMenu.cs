using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

	public string mainMenuLevel;
	public string dificultyMenu;

	public void RestartGame(){
		FindObjectOfType<GameManager>().Reset();
	}

	public void ChangeDificulty(){
		PlayerPrefs.SetString ("lastScene", SceneManager.GetActiveScene ().name);
		SceneManager.LoadScene(dificultyMenu);﻿
	}

	public void QuitToMain(){
		SceneManager.LoadScene(mainMenuLevel);﻿
	}

}
