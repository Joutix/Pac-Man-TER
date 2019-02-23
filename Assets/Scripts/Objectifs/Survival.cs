using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Survival : MonoBehaviour {
	//Var Heure
	public static float Chrono = 40;

	//Objects contenant nos consignes, temps, score etc..  :


	public GameObject Score;
	public GameObject Consigne;
	public GameObject Timer; 


	//Objet
	public static GameObject pacman1;
	public static GameObject phantomeR;
	public static GameObject phantomeP;
	public static GameObject phantomeJ;
	public static GameObject phantomeB;
	public GameObject pacgomme;
	public GameObject superPacgomme;
	public GameObject cerise;



	// Use this for initialization
	public void start () {
		
		Score = GameObject.Find("score");
		Consigne = GameObject.Find("Objectif");
		Timer = GameObject.Find("Temps");
		pacman1 = GameObject.Find("pacman(Clone)");
		phantomeR = GameObject.Find("phantomeR(Clone)");
		phantomeP = GameObject.Find("phantomeP(Clone)");
		phantomeJ = GameObject.Find("phantomeJ(Clone)");
		phantomeB = GameObject.Find("phantomeB(Clone)");

		Consigne.GetComponent<Text>().text = "Vous devez survivre " + Chrono + " secondes .";
		Timer.GetComponent<Text>().text = Chrono + " secondes restantes";

	}

	// Update is called once per frame
	public void update () {

		Chrono -= Time.deltaTime;
		Timer.GetComponent<Text> ().text = Chrono + " secondes restantes";
		if(Chrono <= 0){

            Debug.Log("Objectif Reussit");
            //Gestionnaire.NbObjValide += 1;
            GetComponent<Gestionnaire>().savegestio();
            Debug.Log("Sauvegarde Gestionnaire");
            GetComponent<Gestionnaire>().restartmap();
        }


	}
}