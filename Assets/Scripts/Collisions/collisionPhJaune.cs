using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
///  test les collisions des fantomes.
/// </summary>
public class collisionPhJaune : MonoBehaviour {
    public GameObject Gest;

    /// <summary>
    ///  image nécéssaire
    /// </summary>
    public Sprite vivant;
	public Sprite chasser;
	public Sprite mort;
	/// <summary>
	///  Si un objet entre dans la zone de collicsion
	/// </summary>
	void OnTriggerEnter2D(Collider2D coll) {


		if (EatedByYellow.EtatScript == false) {
			/// <summary>
			///  test de collision avec le pacman ou si le fantome est vivant alors le pacman est mangé et la partie est perdu.
			/// </summary>
			if (coll.gameObject.tag == "pacman" && GetComponent<SpriteRenderer> ().sprite == vivant) {
				Destroy (coll.gameObject);
                if (PlayerPrefs.GetInt("EtatObj") == 1)
                {
                    SceneManager.LoadScene(13);
                }
                else
                {
                    SceneManager.LoadScene("Defaite");
                }
			}
			/// <summary>
			///  test de collision avec pacman si le fantome est chasser alors il meurt.
			/// </summary>
			if (coll.gameObject.tag == "pacman" && GetComponent<SpriteRenderer> ().sprite == chasser) {
				gameObject.GetComponent<SpriteRenderer> ().sprite = mort;
				coll.gameObject.GetComponent<collisionPacman> ().score += 200;
			}

		}
		else{
            if (coll.gameObject.tag == "pacman" && GetComponent<SpriteRenderer>().sprite == chasser)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = mort;
            }
            if (coll.gameObject.tag == "pacman" && GetComponent<SpriteRenderer> ().sprite == vivant) {
                EatedByYellow.EtatScript = false;
                Debug.Log("Objectif Reussit");
                //  Gestionnaire.NbObjValide += 1;
                Gest = GameObject.Find("Gestionnaire");
                Gest.GetComponent<Gestionnaire>().savegestio();
                Debug.Log("Sauvegarde Gestionnaire");
                Gest.GetComponent<Gestionnaire>().restartmap();
            }


		}
	}
}