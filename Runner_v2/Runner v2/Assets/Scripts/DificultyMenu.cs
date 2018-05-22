using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DificultyMenu : MonoBehaviour {

	public void changeFacil(){
		PlayerPrefs.SetInt ("dificulty", 1);
		SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));﻿
	}

	public void changeNormal(){
		PlayerPrefs.SetInt ("dificulty", 2);
		SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));﻿
	}

	public void changeDificil(){
		PlayerPrefs.SetInt ("dificulty", 3);
		SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));﻿
	}

}
