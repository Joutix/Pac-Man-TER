using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectifTimer : MonoBehaviour
{

    //Var Heure
    public static float Chrono = 40;

    //Variables de texte :


    public GameObject Score;
    public GameObject Consigne;
    public GameObject Timer;

    public Sprite mort;



    //Objet
    public GameObject pacman1;
    public static GameObject phantomeR;
    public static GameObject phantomeP;
    public static GameObject phantomeJ;
    public static GameObject phantomeB;
    /*public GameObject pacgomme;
	public GameObject superPacgomme;
	public GameObject cerise; */

    private bool mortR;
    private bool mortP;
    private bool mortJ;
    private bool mortB;




    // Use this for initialization
    public void start()
    {
        mortR = false;
        mortP = false;
        mortJ = false;
        mortB = false;
        Chrono = 40;
        Score = GameObject.Find("score");
        Consigne = GameObject.Find("Objectif");
        Timer = GameObject.Find("Temps");
        pacman1 = GameObject.Find("pacman(Clone)");
        phantomeR = GameObject.Find("phantomeR(Clone)");
        phantomeP = GameObject.Find("phantomeP(Clone)");
        phantomeJ = GameObject.Find("phantomeJ(Clone)");
        phantomeB = GameObject.Find("phantomeB(Clone)");

        Consigne.GetComponent<Text>().text = "Manger tous les fantomes avant le temps impartie";
        Timer.GetComponent<Text>().text = Chrono + " secondes restantes";



    }

    // Update is called once per frame
    public void update()
    {

        Chrono -= Time.deltaTime;
        Timer.GetComponent<Text>().text = Chrono + "secondes restantes";
        if (Chrono <= 0)
        {
            //Load Scene Defaite
            SceneManager.LoadScene(13);
        }
        if (mortB && mortJ && mortP && mortR)
        {
          //  Gestionnaire.NbObjValide += 1;
            GetComponent<Gestionnaire>().savegestio();
            GetComponent<Gestionnaire>().restartmap();

        }
        else
        {
            if (phantomeR.GetComponent<SpriteRenderer>().sprite == mort)
            {
                mortR = true;
            }
            if (phantomeP.GetComponent<SpriteRenderer>().sprite == mort)
            {
                mortP = true;
            }
            if (phantomeJ.GetComponent<SpriteRenderer>().sprite == mort)
            {
                mortJ = true;
            }

            if (phantomeB.GetComponent<SpriteRenderer>().sprite == mort)
            {
                mortB = true;
            }
        }
    }
}
