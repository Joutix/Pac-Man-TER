using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EatTheYellow : MonoBehaviour
{
    
    //Var Heure
    public static float Chrono = 40;

    //Objects contenant nos consignes, temps, score etc..  :


    public GameObject Score;
    public GameObject Consigne;
    public GameObject Timer;

    private bool mortJ;


    //Objet
    public Sprite mort;

    //public GameObject pacman1;
    //public GameObject phantomeR;
    //public GameObject phantomeP;
    public static GameObject phantomeJ;
    //public GameObject phantomeB;
    //public GameObject pacgomme;
    //public GameObject superPacgomme;
    //public GameObject cerise;



    // Use this for initialization
    public void start()
    {
        mortJ = false;
        Chrono = 40;

        Score = GameObject.Find("score");
        Consigne = GameObject.Find("Objectif");
        Timer = GameObject.Find("Temps");
        //	pacman1 = GameObject.Find("pacman(Clone)");
        //	phantomeR = GameObject.Find("phantomeR(Clone)");
        //	phantomeP = GameObject.Find("phantomeP(Clone)"); 
        phantomeJ = GameObject.Find("phantomeJ(Clone)");
        //	phantomeB = GameObject.Find("phantomeB(Clone)");

        if (PlayerPrefs.GetInt("enchainement") == 1) {
			Consigne.GetComponent<Text> ().text = "Troisieme cible à manger : Fantome jaune" ;
			Timer.GetComponent<Text> ().text = Chrono + " secondes restantes";
		} else {
        Consigne.GetComponent<Text>().text = "Vous devez manger le fantome Jaune avant " + (Chrono - Time.deltaTime) + " secondes .";
        Timer.GetComponent<Text>().text = Chrono + " secondes restantes";
        }


    }

    // Update is called once per frame
    public void update()
    {

        Consigne.GetComponent<Text>().text = "Vous devez manger le fantome Jaune avant " + (Chrono - Time.deltaTime) + " secondes .";
        Chrono = Chrono - Time.deltaTime;
        Timer.GetComponent<Text>().text = Chrono + " secondes restantes";
        if (Chrono <= 0)
        {//Load Scene Defaite
            SceneManager.LoadScene(13);
        }

        else
        {
            if (PlayerPrefs.GetInt("enchainement") == 1)
            {
                if (phantomeJ.GetComponent<SpriteRenderer>().sprite == mort)
                {
                    PlayerPrefs.SetInt("ectJ", 1);
                    Debug.Log("Objectif Reussit");
                    GetComponent<Gestionnaire>().savegestio();
                    Debug.Log("Sauvegarde Gestionnaire");
                    GetComponent<Gestionnaire>().restartmap();

                }
            }
            else
            {

                if (phantomeJ.GetComponent<SpriteRenderer>().sprite == mort)
                {
                    mortJ = true;
                }

                if (mortJ == true)
                {
                    Debug.Log("Objectif Reussit");
                   // Gestionnaire.NbObjValide += 1;
                    GetComponent<Gestionnaire>().savegestio();
                    Debug.Log("Sauvegarde Gestionnaire");
                    GetComponent<Gestionnaire>().restartmap();
                }
            }
        }
    }
}
        
       



