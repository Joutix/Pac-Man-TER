using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Security.Cryptography;

/// <summary>
///  Ce script permet de mettre le pacman en mouvement en fonction des touches.
/// </summary>
public class deplacementPacman : MonoBehaviour {
	/// <summary>
	///  variable vitesse
	/// </summary>
	private int speed ;
	/// <summary>
	///  variables de déplacement
	/// </summary>
	private int inputX;
	private int inputY;


	/// <summary>
	///  variables de si le pacman est en mouvement
	/// </summary>
	private bool move;
	private string memoire;
	/// <summary>
	///  variables de destination
	/// </summary>
	private Vector2 tampon;
	/// <summary>
	///  la tilematrix
	/// </summary>
	private TileMatrix M;

	private RaycastHit2D rayhit;

	public Rigidbody2D pacman;

    public Animator pacman_anim;

	// Use this for initialization
	void Start () {
		pacman =GetComponent<Rigidbody2D> ();
        pacman_anim = GetComponent<Animator> ();
		tampon = pacman.position;
		move = false;
		speed = PlayerPrefs.GetInt ("speedP");
		if (speed == 0) {
			speed = 4;
		}
	}
	
	/// <summary>
	///  à chaque frame
	/// </summary>
	void Update (){

		M = GameObject.Find("LevelsGenerator").GetComponent<LevelsGenerator>().M;

	
		/// <summary>
		///  si touche haut pacman monte
		/// </summary>
		if (Input.GetKey ("up")) {

				memoire = "haut";
		}


		/// <summary>
		///  si touche haut pacman descend
		/// </summary>
		if (Input.GetKey ("down")) {
				memoire = "bas";
			}

		
		/// <summary>
		///  si touche haut pacman va à droite
		/// </summary>
		if (Input.GetKey ("right")) {

				memoire = "droite";
			}
		
		/// <summary>
		///  si touche haut pacman va à gauche
		/// </summary>
		if (Input.GetKey ("left")) {


				memoire = "gauche";
			}

		
		if (inputX == 1 ){


			if (transform.position.x >= tampon.x)  {

				move = false;
			}
		}
		if (inputY == 1) {
			if (transform.position.y >= tampon.y) {
				move = false;
			}
		}

		if (inputX == -1 ){
			if (transform.position.x <= tampon.x) {
				move = false;
			}
		}
		if (inputY == -1) {
			if (transform.position.y <= tampon.y) {
				move = false;
			}
		}




		if (move == false) {
			pacman.position = tampon;
			if (memoire == "haut") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x, pacman.position.y + 0.24f), new Vector2 (pacman.position.x, pacman.position.y + 0.24f), 0.1f);
				if (rayhit && rayhit.collider.tag != "mur" || !rayhit) {
					PlayerPrefs.SetString ("dirP", "haut");


				}
			}			
			if (memoire == "bas") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x, pacman.position.y - 0.24f), new Vector2 (pacman.position.x, pacman.position.y - 0.24f), 0.1f);
				if (rayhit && rayhit.collider.tag != "mur" || !rayhit) {
					PlayerPrefs.SetString ("dirP", "bas");


				}
			}
			if (memoire == "droite") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x + 0.24f, pacman.position.y), new Vector2 (pacman.position.x + 0.24f, pacman.position.y), 0.1f);
				if (rayhit && rayhit.collider.tag != "mur" || !rayhit) {
					PlayerPrefs.SetString ("dirP", "droite");


				}
			}
			if (memoire == "gauche") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x - 0.24f, pacman.position.y), new Vector2 (pacman.position.x - 0.24f, pacman.position.y ), 0.1f);
				if (rayhit && rayhit.collider.tag != "mur" || !rayhit) {
					PlayerPrefs.SetString ("dirP", "gauche");


				}
			}

            if (PlayerPrefs.GetString ("dirP") == "haut") {

				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x, pacman.position.y + 0.24f), new Vector2 (pacman.position.x, pacman.position.y + 0.24f), 0.1f);
				inputY = 1;
				inputX = 0;

                if (!rayhit || rayhit.collider.tag != "mur") {

					tampon = new Vector2 (tampon.x, tampon.y + 0.24f);
					move = true;
                    animate();
                    
                }
			}

			if (PlayerPrefs.GetString ("dirP") == "bas") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x, pacman.position.y - 0.24f), new Vector2 (pacman.position.x, pacman.position.y - 0.24f), 0.1f);
				inputY = -1;
				inputX = 0;


                if (!rayhit || rayhit.collider.tag != "mur") {

					tampon = new Vector2 (tampon.x, tampon.y - 0.24f);
					move = true;
                    animate();

                }
			}

			if (PlayerPrefs.GetString ("dirP") == "droite") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x + 0.24f, pacman.position.y), new Vector2 (pacman.position.x + 0.24f, pacman.position.y), 0.1f);
				inputY = 0;
				inputX = 1;

                if (!rayhit || rayhit.collider.tag != "mur") {

					tampon = new Vector2 (tampon.x + 0.24f, tampon.y);
					move = true;
                    animate();

                }
			}

			if (PlayerPrefs.GetString ("dirP") == "gauche") {
				rayhit = Physics2D.Raycast (new Vector2 (pacman.position.x - 0.24f, pacman.position.y), new Vector2 (pacman.position.x - 0.24f, pacman.position.y ), 0.1f);
				inputY = 0;
				inputX = -1;

                if (!rayhit ||rayhit.collider.tag != "mur") {

					tampon = new Vector2 (tampon.x - 0.24f, tampon.y);
					move = true;
                    animate();

                }
			}
		}

	}

    public void TP(float x, float y)
    {
        Debug.Log("x : " + x + " y : " + y + " M.largeur : " + -((M.hauteur * 0.24f) - 0.25f));
        if (x == 0)
        {

            memoire = "droite";
            rayhit = Physics2D.Raycast(new Vector2(x + 0.24f, y), new Vector2(x + 0.24f, y), 0.1f);
            inputY = 0;
            inputX = 1;

            if (!rayhit || rayhit.collider.tag != "mur")
            {
                tampon = new Vector2(x + 0.24f, y);
                move = true;
                animate();

            }

        }
        else if (x >= ((M.largeur * 0.24f) - 0.25f))
        {

            memoire = "gauche";
            rayhit = Physics2D.Raycast(new Vector2(x - 0.24f, y), new Vector2(x - 0.24f, y), 0.1f);
            inputY = 0;
            inputX = -1;

            if (!rayhit || rayhit.collider.tag != "mur")
            {
                tampon = new Vector2(x - 0.24f, y);
                move = true;
                animate();

            }

        }
        else if (y == 0)
        {

            memoire = "bas";
            rayhit = Physics2D.Raycast(new Vector2(x, y - 0.24f), new Vector2(x, y - 0.24f), 0.1f);
            inputY = -1;
            inputX = 0;

            if (!rayhit || rayhit.collider.tag != "mur")
            {

                tampon = new Vector2(x, y - 0.24f);
                move = true;
                animate();

            }

        }
        else if (y <= -((M.hauteur * 0.24f) - 0.25f))
        {

            memoire = "haut";
            rayhit = Physics2D.Raycast(new Vector2(x, y + 0.24f), new Vector2(x, y + 0.24f), 0.1f);
            inputY = 1;
            inputX = 0;

            if (!rayhit || rayhit.collider.tag != "mur")
            {

                tampon = new Vector2(x, y + 0.24f);
                move = true;
                animate();

            }

        }

    }


    void FixedUpdate(){
		/// <summary>
		///  déplacement
		/// </summary>
		pacman.velocity = new Vector2 ((speed * inputX)*0.24f, (speed * inputY)*0.24f);

	}
	    void animate()
    {
        GetComponent<Animator>().SetFloat("DirX", inputX);
        GetComponent<Animator>().SetFloat("DirY", inputY);
    }

}
