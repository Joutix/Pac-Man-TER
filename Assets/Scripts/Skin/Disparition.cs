using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Disparition : MonoBehaviour {
    public Dropdown chroma;
    public Dropdown chroma2;
    public Dropdown chroma3;
    public Dropdown chroma4;
    public Dropdown chroma5;
    public Dropdown chroma6;
    public Dropdown chroma7;
    public Dropdown chroma8;
    public Dropdown chroma9;
    public Dropdown chroma10;
    public Dropdown chroma11;
    public Dropdown chroma12;
    public Dropdown chroma13;
    public Dropdown chroma14;
    public Dropdown chroma15;
    

    public void enlevechroma()
    {
        chroma.gameObject.SetActive(true);
        chroma2.gameObject.SetActive(false);
        chroma3.gameObject.SetActive(false);
        chroma4.gameObject.SetActive(false);
        chroma5.gameObject.SetActive(false);
        chroma6.gameObject.SetActive(false);
        chroma7.gameObject.SetActive(false);
        chroma8.gameObject.SetActive(false);
        chroma9.gameObject.SetActive(false);
        chroma10.gameObject.SetActive(false);
        chroma11.gameObject.SetActive(false);
        chroma12.gameObject.SetActive(false);
        chroma13.gameObject.SetActive(false);
        chroma14.gameObject.SetActive(false);
        chroma15.gameObject.SetActive(false);
        
    }
}
