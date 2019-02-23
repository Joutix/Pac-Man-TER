using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetVAR : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("OBV", 0);
        PlayerPrefs.SetInt("OBT", 0);
        PlayerPrefs.SetInt("etatObj", 0);
        PlayerPrefs.SetInt("enchainement", 0);
        PlayerPrefs.SetInt("ectR", 0);
        PlayerPrefs.SetInt("ectB", 0);
        PlayerPrefs.SetInt("ectY", 0);

    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
