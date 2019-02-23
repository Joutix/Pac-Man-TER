using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gestionnaire : MonoBehaviour
{

    //Variable Nombre d'objectif Total a realiser par le joueur pour gagner la partie;
    public static int NbObjTotal = 3;

    //Variable booleen pour lancer un nouvelle objectif
    public static bool rechercheNextO;


    public float Timer;

    //Nombre d'objectif validé par le joueur pendant la partie
    public static int NbObjValide;

    public static int ResultatRand;


    //Variable d'enchainement au niveau des objectifs comme Eat the Target ou Eat By Target;
    public static bool enchainement;



    //Awake


    void Awake()
    {



    }

    //Start

    public void savegestio()
    { // OBT : Objectif Total
      // OBV : Objectif Validé
       Debug.Log("Debut de la sauvegarde du Gestionnaire");
        PlayerPrefs.SetInt("OBT", NbObjTotal);
        Debug.Log("Objectif Total sauvegardé");
        PlayerPrefs.SetInt("OBV", ((PlayerPrefs.GetInt("OBV"))+1));
        Debug.Log("Objectif Validé de save : " + PlayerPrefs.GetInt("OBV"));
        Debug.Log("Fin de la sauvegarde, relancement de la scene objectif"); 
   
    }

    public void restartmap()
    {

        SceneManager.LoadScene(12);



    }

    void Start()
    {
        PlayerPrefs.SetInt("EtatObj", 1);
        ResultatRand = Random.Range(1,10);
    
        NbObjValide = PlayerPrefs.GetInt("OBV");
        // NbObjTotal = PlayerPrefs.GetInt("OBT");
     
        initObj();

    }

    public void rand()
    {
        ResultatRand =  Random.Range (1, 10);
    }

    public void initObj()
    {
        if (PlayerPrefs.GetInt("ectR")==1)
        {
            ResultatRand = 3;
        }
        if (PlayerPrefs.GetInt("ectB")==1)
        {
            ResultatRand = 5;
        }
        if (PlayerPrefs.GetInt("ectY")==1)
        {
            ResultatRand = 2;
        }





        if (PlayerPrefs.GetInt("OBV") == NbObjTotal)
        {
            SceneManager.LoadScene(14);
        }



        switch (ResultatRand)
        {
            case 1:

                GetComponent<ObjectifTimer>().start();

                break;

            case 2:
                GetComponent<EatTheRose>().start();


                break;

            case 3:

                GetComponent<EatTheBlue>().start();

                break;
            case 4:

                GetComponent<EatTheRed>().start();

                break;
            case 5:

                GetComponent<EatTheYellow>().start();

                break;
                	case 6:

                        GetComponent<EatedByBlue>().start();

                        break;
                    case 7:

                        GetComponent<EatedByYellow>().start();

                        break;

                    case 8:

                        GetComponent<EatedByRed>().start();

                        break;

                    case 9:

                        GetComponent<EatedByBlue>().start();

                        break;

                   /* case 10:

                        GetComponent<Survival>().start();

                        break;
                        */
                    case 10:

                PlayerPrefs.SetInt("enchainement", 1);
                GetComponent<EatTheRed> ().start ();

                        break;
                        
        }

    }




    //Update every frames..
    void Update()
    {


        switch (ResultatRand)
        {
            case 1:

                GetComponent<ObjectifTimer>().update();

                break;

            case 2:
                GetComponent<EatTheRose>().update();


                break;

            case 3:

                GetComponent<EatTheBlue>().update();

                break;
            case 4:

                GetComponent<EatTheRed>().update();

                break;
            case 5:

                GetComponent<EatTheYellow>().update();

                break;
                		case 6:

                            GetComponent<EatedByBlue>().update();

                            break;
                        case 7:

                            GetComponent<EatedByYellow>().update();

                            break;

                        case 8:

                            GetComponent<EatedByRed>().update();

                            break;

                        case 9:

                            GetComponent<EatedByBlue>().update();

                            break;

            /*case 10:

                GetComponent<Survival>().update();

                break;
                */
            case 10:

                
                GetComponent<EatTheRed>().update();

                break;
        }



    }



}





