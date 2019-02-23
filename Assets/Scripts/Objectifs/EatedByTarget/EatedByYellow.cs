using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EatedByYellow : MonoBehaviour {

	//Var etat de mon script : En cour ou non.
	public static bool EtatScript;
	//Var Heure
	public static float Chrono = 40;

	//Objects contenant nos consignes, temps, score etc..  :

	public GameObject Score;
	public GameObject Consigne;
	public GameObject Timer; 


	//Objet
	/*public GameObject pacman1;
	public GameObject phantomeR;
	public GameObject phantomeP;
	public GameObject phantomeJ;
	public GameObject phantomeB;
	public GameObject pacgomme;
	public GameObject superPacgomme;
	public GameObject cerise; */




	// Use this for initialization
	public void start () {
		
		Score = GameObject.Find("score");
		Consigne = GameObject.Find("Objectif");
		Timer = GameObject.Find("Temps");
		/*pacman1 = GameObject.Find("pacman(Clone)");
		phantomeR = GameObject.Find("phantomeR(Clone)");
		phantomeP = GameObject.Find("phantomeP(Clone)");
		phantomeJ = GameObject.Find("phantomeJ(Clone)");
		phantomeB = GameObject.Find("phantomeB(Clone)"); */

		Consigne.GetComponent<Text>().text = "Vous avez " + Chrono + " secondes pour vous faire manger par le fantome jaune .";
		Timer.GetComponent<Text>().text = Chrono + " secondes restantes";
		EtatScript = true;

	}

	// Update is called once per frame
	public void update () {

		Chrono -= Time.deltaTime;
		Timer.GetComponent<Text> ().text = Chrono + " secondes restantes";
		if (Chrono <= 0) {
			EtatScript = false;
			SceneManager.LoadScene (13);
		} 

	}
}
