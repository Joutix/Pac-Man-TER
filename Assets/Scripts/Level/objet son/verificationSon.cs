using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class verificationSon : MonoBehaviour {

    public Slider slider;

	// Use this for initialization
	void Awake () {
		Debug.Log ("yo");
		if (GameObject.Find ("Son") != null) {

            slider.value = GameObject.Find("Son").GetComponent<AudioSource>().volume;

			if (GameObject.Find ("Son").GetComponent<AudioSource>().clip == GetComponent<AudioSource>().clip) {
				Destroy (GetComponent<AudioSource> ());
				Destroy (GetComponent<AudioListener> ());
			} else {
                GameObject.Find("Son").GetComponent<AudioSource>().Stop();
                GameObject.Find("Son").GetComponent<AudioSource>().clip = GetComponent<AudioSource>().clip;
                Destroy (GetComponent<AudioSource>());
                Destroy(GetComponent<AudioListener>());
                GameObject.Find("Son").GetComponent<AudioSource>().Play();

                GameObject.Find("Son").GetComponent<AudioSource>().loop = true;

                if (GameObject.Find("Son").GetComponent<AudioSource>().clip.name == "Game Over" ) {
                    GameObject.Find("Son").GetComponent<AudioSource>().loop = false;
                }
			}
		}
	}

}
