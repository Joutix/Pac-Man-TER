using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EatTheRed : MonoBehaviour {
	//Var Heure
	public static float Chrono = 40;

    //Objects contenant nos consignes, temps, score etc..  :
    public static bool EtatScript;

	public GameObject Score;
	public GameObject Consigne;
	public GameObject Timer;




	//Objet

	public Sprite mort;
//	public GameObject pacman1;
	public static GameObject phantomeR;
    /*	public GameObject phantomeP;
        public GameObject phantomeJ;
        public GameObject phantomeB;
        public GameObject pacgomme;
        public GameObject superPacgomme;
        public GameObject cerise; */

    private bool mortR;




	// Use this for initialization
	public void start () {

        Chrono =40;
        mortR = false;

		
		Score = GameObject.Find("score");
		Consigne = GameObject.Find("Objectif");
		Timer = GameObject.Find("Temps");
	//	pacman1 = GameObject.Find("pacman(Clone)");
		phantomeR = GameObject.Find("phantomeR(Clone)");
	/*	phantomeP = GameObject.Find("phantomeP(Clone)");
		phantomeJ = GameObject.Find("phantomeJ(Clone)");
		phantomeB = GameObject.Find("phantomeB(Clone)"); */
		if (PlayerPrefs.GetInt("enchainement")==1) {
			Consigne.GetComponent<Text> ().text = "Vous allez devoir manger une succession de fantome dans le bon ordre. Premiere cible : Fantome rouge " ;
			Timer.GetComponent<Text> ().text = Chrono + " secondes restantes";
		} else {
			Consigne.GetComponent<Text> ().text = "Vous devez manger le fantome rouge en moins de " + Chrono + " secondes .";
			Timer.GetComponent<Text> ().text = Chrono + " secondes restantes";
		}

	}

	// Update is called once per frame
	public void update () {

		Chrono -= Time.deltaTime;
		Timer.GetComponent<Text> ().text = Chrono + " secondes restantes";
		if (Chrono <= 0) {
			SceneManager.LoadScene (13);
		} 
		else {
            if (PlayerPrefs.GetInt("enchainement")==1)
            {
                if (phantomeR.GetComponent<SpriteRenderer>().sprite == mort)
                {
                    PlayerPrefs.SetInt("ectR", 1);
                    Debug.Log("Objectif Reussit");
                    GetComponent<Gestionnaire>().savegestio();
                    Debug.Log("Sauvegarde Gestionnaire");
                    GetComponent<Gestionnaire>().restartmap();
                    
                }
            }
            else
            {


                if (phantomeR.GetComponent<SpriteRenderer>().sprite == mort)
                {
                    mortR = true;
                }

                if (mortR == true)
                {
                   // Gestionnaire.NbObjValide += 1;
                    GetComponent<Gestionnaire>().savegestio();
                    GetComponent<Gestionnaire>().restartmap();
                }
            }
        }
    }
}

