using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3 platformStartPoints;

	public PlayerController thePlayer;
	private Vector3 playerStartPoint;

	private PlatformDestroyer[] platformList;

	private ScoreManager theScoreManager;

	public DeathMenu theDeathScreen;

	public Text theLetra;

	private int dificultad;

	public int GetDificultad(){
		return dificultad;
	}

	// Use this for initialization
	void Start () {
		dificultad = 1;
		dificultad = PlayerPrefs.GetInt ("dificulty");
		platformStartPoints = platformGenerator.position;
		playerStartPoint = thePlayer.transform.position;
		theScoreManager = FindObjectOfType<ScoreManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerLost () {
		thePlayer.gameObject.SetActive (false);
		theDeathScreen.gameObject.SetActive (true);
		theLetra.gameObject.SetActive (false);
		//StartCoroutine ("RestartGameCo");
	}

	public void Reset(){
		theDeathScreen.gameObject.SetActive (false);
		theLetra.gameObject.SetActive (true);

		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for (int i = 0; i < platformList.Length; i++) {
			platformList [i].gameObject.SetActive (false);
		}
		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoints;
		thePlayer.gameObject.SetActive (true);

		theScoreManager.ResetScore ();
	}

	/*public IEnumerator RestartGameCo () {
		theScoreManager.scoreIncreasing = false;

		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		platformList = FindObjectsOfType<PlatformDestroyer> ();
		for (int i = 0; i < platformList.Length; i++) {
			platformList [i].gameObject.SetActive (false);
		}
		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoints;
		thePlayer.gameObject.SetActive (true);

		theScoreManager.scoreCount = 0;
		theScoreManager.scoreIncreasing = true;
	}*/

}
