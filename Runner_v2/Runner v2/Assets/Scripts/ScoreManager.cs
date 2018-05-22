using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text scoreText;
	public Text highScoreText;
	public int scoreCount;
	public int highScoreCount;

	public Text letraText;
	private int letraNum;

	// Use this for initialization
	void Start () {
		CambiarLetra ();
		highScoreCount = 0;
		if(PlayerPrefs.HasKey("HighScore")) {
			highScoreCount = PlayerPrefs.GetInt ("HighScore");
		}
		scoreText.text = "0";
		highScoreText.text = ""+highScoreCount;
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	public void ResetScore(){
		scoreCount = 0;
		scoreText.text = "" + scoreCount;
        CambiarLetra();
    }

	public void AddScore(int pointsToAdd){
		scoreCount += pointsToAdd;
		if (scoreCount > highScoreCount) {
			highScoreCount = scoreCount;
			PlayerPrefs.SetInt ("HighScore", highScoreCount);
			highScoreText.text = "" + scoreCount;
		}
		scoreText.text = "" + scoreCount;
		CambiarLetra ();
	}

	private void CambiarLetra(){
		letraNum = Random.Range(0,50) + 1;
		switch (letraNum) {
			case 1: letraText.text = "CASA"; break;
			case 2: letraText.text = "HOLA"; break;
			case 3: letraText.text = "PERRO"; break;
			case 4: letraText.text = "MIRAR"; break;
			case 5: letraText.text = "OLER"; break;
            case 6: letraText.text = "AGUA"; break;
            case 7: letraText.text = "ARBOL"; break;
            case 8: letraText.text = "AMIGO"; break;
            case 9: letraText.text = "AVION"; break;
            case 10: letraText.text = "AZUL"; break;
            case 11: letraText.text = "BARCO"; break;
            case 12: letraText.text = "CIELO"; break;
            case 13: letraText.text = "COMER"; break;
            case 14: letraText.text = "FLOR"; break;
            case 15: letraText.text = "GATO"; break;
            case 16: letraText.text = "FRESA"; break;
            case 17: letraText.text = "HOJA"; break;
            case 18: letraText.text = "JUGAR"; break;
            case 19: letraText.text = "LEER"; break;
            case 20: letraText.text = "LIBRO"; break;
            case 21: letraText.text = "MADRE"; break;
            case 22: letraText.text = "MESA"; break;
            case 23: letraText.text = "OSO"; break;
            case 24: letraText.text = "PADRE"; break;
            case 25: letraText.text = "PATO"; break;
            case 26: letraText.text = "PERA"; break;
            case 27: letraText.text = "PEZ"; break;
            case 28: letraText.text = "POLLO"; break;
            case 29: letraText.text = "QUESO"; break;
            case 30: letraText.text = "RANA"; break;
            case 31: letraText.text = "REIR"; break;
            case 32: letraText.text = "RELOJ"; break;
            case 33: letraText.text = "ROJO"; break;
            case 34: letraText.text = "ROPA"; break;
            case 35: letraText.text = "SILLA"; break;
            case 36: letraText.text = "TAZA"; break;
            case 37: letraText.text = "TREN"; break;
            case 38: letraText.text = "VERDE"; break;
            case 39: letraText.text = "LAPIZ"; break;
            case 40: letraText.text = "PLUMA"; break;
            case 41: letraText.text = "AYER"; break;
            case 42: letraText.text = "NUEVO"; break;
            case 43: letraText.text = "NOCHE"; break;
            case 44: letraText.text = "DIA"; break;
            case 45: letraText.text = "MANO"; break;
            case 46: letraText.text = "OJOS"; break;
            case 47: letraText.text = "CARRO"; break;
            case 48: letraText.text = "MESES"; break;
            case 49: letraText.text = "HORA"; break;
            case 50: letraText.text = "BIEN"; break;
        }
	}

	public int GetLetra(){
		return letraNum;
	}

}
