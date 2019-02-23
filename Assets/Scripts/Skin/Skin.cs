using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skin : MonoBehaviour
{
    public GameObject pacman;
    public RuntimeAnimatorController africain;
    public RuntimeAnimatorController asiatique;
    public RuntimeAnimatorController tiles_36;
    public RuntimeAnimatorController hulk;
    public RuntimeAnimatorController lgbt;
    public RuntimeAnimatorController mrrobot;
    public RuntimeAnimatorController ninja;
    public RuntimeAnimatorController noir;
    public RuntimeAnimatorController pacwoman;
    public RuntimeAnimatorController red;
    public RuntimeAnimatorController rose;

    public void ValidationSkin(Dropdown drp)
    {

        int val = drp.value;

        switch (val)
        {

            case 0:
                pacman.GetComponent<Animator>().runtimeAnimatorController = tiles_36;
                break;

            case 1:
                pacman.GetComponent<Animator>().runtimeAnimatorController = africain;
                break;

            case 2:
                pacman.GetComponent<Animator>().runtimeAnimatorController = asiatique;
                break;

            case 3:
                pacman.GetComponent<Animator>().runtimeAnimatorController = hulk;
                break;

            case 4:
                pacman.GetComponent<Animator>().runtimeAnimatorController = lgbt;
                break;

            case 5:
                pacman.GetComponent<Animator>().runtimeAnimatorController = mrrobot;
                break;

            case 6:
                pacman.GetComponent<Animator>().runtimeAnimatorController = ninja;
                break;

            case 7:
                pacman.GetComponent<Animator>().runtimeAnimatorController = noir;
                break;

            case 8:
                pacman.GetComponent<Animator>().runtimeAnimatorController = pacwoman;
                break;

            case 9:
                pacman.GetComponent<Animator>().runtimeAnimatorController = red;
                break;

            case 10:
                pacman.GetComponent<Animator>().runtimeAnimatorController = rose;
                break;

        }

    }
}