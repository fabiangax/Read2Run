using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour {

	public Transform generationPoint;

	public ObjectPooler thePlatformPool;

	private int platformWidth;

	private GameManager theGameManager;

	//public ObjectPooler obstaclesPool;

	// Use this for initialization
	void Start () {
		theGameManager = FindObjectOfType<GameManager> ();
		switch(theGameManager.GetDificultad()){
			case 1: platformWidth = 10; break;
			case 2: platformWidth = 8; break;
			case 3: platformWidth = 6; break;
		}
		//platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generationPoint.position.x) {
			transform.position = new Vector3 (transform.position.x + platformWidth, transform.position.y, transform.position.z);
			//Instantiate (thePlatform, transform.position, transform.rotation);
			GameObject newPlatform = thePlatformPool.GetPooledObject();
			newPlatform.transform.position = transform.position;
			newPlatform.transform.rotation = transform.rotation;
			newPlatform.SetActive (true);
		}	
	}
}
