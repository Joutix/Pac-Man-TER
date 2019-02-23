using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portails : MonoBehaviour {

    private TileMatrix M;
    public Transform portail;
    public Transform portail2;
    public GameObject pacman1;
	public GameObject phantomeR;
	public GameObject phantomeP;
	public GameObject phantomeJ;
	public GameObject phantomeB;

    private bool trouve;
    public bool passeR;
    public bool passeP;
    public bool passeJ;
    public bool passeB;

    // Use this for initialization
    void Start () {
        
        passeR = true;
        passeP = true;
        passeJ = true;
        passeB = true;
        portail = GetComponent<Transform>();
        pacman1 = GameObject.Find("pacman(Clone)");
        phantomeB = GameObject.Find("phantomeB(Clone)");
        phantomeR = GameObject.Find("phantomeR(Clone)");
        phantomeJ = GameObject.Find("phantomeJ(Clone)");
        phantomeP = GameObject.Find("phantomeP(Clone)");

    }
	
	// Update is called once per frame
	void Update () {

        M = GameObject.Find("LevelsGenerator").GetComponent<LevelsGenerator>().M;

    }

    public void TP(string tag)
    {
   
        if (tag == "phantomeB")
        {

            if (passeB)
            {

                phantomeB.GetComponent<DeplacementphantomeB>().TP(portail2.position.x, portail.position.y);
                portail2.GetComponentInParent<Portails>().passeB = false;

            }

        }

        if (tag == "phantomeR")
        {

            if (passeR)
            {

                phantomeR.GetComponent<DeplacementphantomeR>().TP(portail2.position.x, portail.position.y);
                portail2.GetComponentInParent<Portails>().passeR = false;

            }

        }

        if (tag == "phantomeJ")
        {

            if (passeJ)
            {

                phantomeJ.GetComponent<DeplacementphantomeJ>().TP(portail2.position.x, portail.position.y);
                portail2.GetComponentInParent<Portails>().passeJ = false;

            }

        }

        if (tag == "phantomeP")
        {

            if (passeP)
            {

                phantomeP.GetComponent<DeplacementphantomeP>().TP(portail2.position.x, portail.position.y);
                portail2.GetComponentInParent<Portails>().passeP = false;

            }

        }

    }

    void OnTriggerStay2D(Collider2D coll)
    {
        Debug.Log(coll.gameObject.tag);

        if (coll.gameObject.tag == "pacman")
        {

            pacman1.GetComponent<deplacementPacman>().TP(portail2.position.x, portail2.position.y);

        }

    }

}
