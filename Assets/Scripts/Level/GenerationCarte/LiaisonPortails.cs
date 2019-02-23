using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiaisonPortails : MonoBehaviour {

    //Lie les portails entre eux
    public void liePortails(List<GameObject> portails, TileMatrix M)
    {

        foreach (GameObject item in portails)
        {
            Debug.Log("x : " + item.GetComponent<Transform>().position.x + " y : " + item.GetComponent<Transform>().position.y);
            item.GetComponent<Portails>().portail = item.GetComponent<Transform>();

            if (item.GetComponent<Portails>().portail2 == null)
            {

                if (item.GetComponent<Portails>().portail.position.y == 0)
                {
                    List<GameObject> temp = portails;
                    temp = SortCompareY0(portails, M);

                    bool trouve = false;

                    foreach (GameObject i in temp)
                    {

                        if ((i.GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.x == 0) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.y == 0) && (i.GetComponent<Portails>().portail2 == null) && !(i.GetComponent<Transform>().position == item.GetComponent<Portails>().portail.position))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                    }
                    if (!trouve)
                    {

                        item.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;

                    }

                }
                else if (item.GetComponent<Portails>().portail.position.x == 0)
                {

                    List<GameObject> temp = portails;
                    temp = SortCompareX0(portails, M);

                    bool trouve = false;

                    foreach (GameObject i in temp)
                    {
                        if ((i.GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.y == 0) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.x == 0) && (i.GetComponent<Portails>().portail2 == null) && !(i.GetComponent<Transform>().position == item.GetComponent<Portails>().portail.position))
                        {

                            item.GetComponent<Portails>().portail2 = item.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                    }
                    if (!trouve)
                    {

                        item.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;

                    }

                }
                else if (item.GetComponent<Portails>().portail.position.x >= ((M.largeur * 0.24f) - 0.25f))
                {

                    bool trouve = false;

                    foreach (GameObject i in portails)
                    {
                        if ((i.GetComponent<Transform>().position.x == 0) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.y == 0) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null) && !(i.GetComponent<Transform>().position == item.GetComponent<Portails>().portail.position))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                    }
                    if (!trouve)
                    {

                        item.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;

                    }

                }
                else if (item.GetComponent<Portails>().portail.position.y <= -((M.hauteur * 0.24f) - 0.25f))
                {

                    bool trouve = false;

                    foreach (GameObject i in portails)
                    {
                        if ((i.GetComponent<Transform>().position.y == 0) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.x == 0) && (i.GetComponent<Portails>().portail2 == null))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                        else if ((i.GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) && (i.GetComponent<Portails>().portail2 == null) && !(item.GetComponent<Transform>().position == item.GetComponent<Portails>().portail.position))
                        {

                            item.GetComponent<Portails>().portail2 = i.GetComponent<Transform>();
                            i.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;
                            trouve = true;
                            break;

                        }
                    }
                    if (!trouve)
                    {

                        item.GetComponent<Portails>().portail2 = item.GetComponent<Portails>().portail;

                    }

                }

            }
            SortN(portails, M);

        }

    }

    private List<GameObject> SortCompareY0(List<GameObject> p, TileMatrix M)
    {
        List<GameObject> temp = p;
        for (int i = 0; i < temp.Count; i++)
        {

            for (int k = 0; k < i; k++)
            {

                if (temp[i].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f))
                {
                    if (temp[k].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f))
                    {
                        if (temp[i].GetComponent<Transform>().position.x < temp[k].GetComponent<Transform>().position.x)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }
                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)) && !(temp[k].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)))
                {

                    if (temp[k].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f))
                    {
                        if (temp[i].GetComponent<Transform>().position.y > temp[k].GetComponent<Transform>().position.y)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }
                    }
                    else
                    {
                        
                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.x == 0) && !((temp[k].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) || (temp[k].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f))))
                {

                    if (temp[k].GetComponent<Transform>().position.x == 0)
                    {

                        if (temp[i].GetComponent<Transform>().position.y > temp[k].GetComponent<Transform>().position.y)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }

                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.y == 0) && (temp[k].GetComponent<Transform>().position.y == 0))
                {

                    GameObject t = temp[k];
                    temp[k] = temp[i];
                    temp[i] = t;

                }
                

            }

        }

        return temp;

    }

    private List<GameObject> SortCompareX0(List<GameObject> p, TileMatrix M)
    {
        List<GameObject> temp = p;
        for (int i = 0; i < temp.Count; i++)
        {

            for (int k = 0; k < i; k++)
            {

                if (temp[i].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f))
                {
                    if (temp[k].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f))
                    {
                        if (temp[i].GetComponent<Transform>().position.y > temp[k].GetComponent<Transform>().position.y)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }
                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) && !(temp[k].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)))
                {

                    if (temp[k].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f))
                    {
                        if (temp[i].GetComponent<Transform>().position.x < temp[k].GetComponent<Transform>().position.x)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }
                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.y == 0) && !((temp[k].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) || (temp[k].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f))))
                {

                    if (temp[k].GetComponent<Transform>().position.y == 0)
                    {

                        if (temp[i].GetComponent<Transform>().position.x < temp[k].GetComponent<Transform>().position.x)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }

                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.x == 0) && (temp[k].GetComponent<Transform>().position.x == 0))
                {

                    GameObject t = temp[k];
                    temp[k] = temp[i];
                    temp[i] = t;

                }

            }

        }

        return temp;

    }

    private void SortN(List<GameObject> temp, TileMatrix M)
    {

        for (int i = 0; i < temp.Count; i++)
        {

            for (int k = 0; k < i; k++)
            {

                if (temp[i].GetComponent<Transform>().position.y == 0)
                {
                    if (temp[k].GetComponent<Transform>().position.y == 0)
                    {
                        if (temp[i].GetComponent<Transform>().position.x < temp[k].GetComponent<Transform>().position.x)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }
                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.x == 0) && !(temp[k].GetComponent<Transform>().position.y == 0))
                {

                    if (temp[k].GetComponent<Transform>().position.x == 0)
                    {
                        if (temp[i].GetComponent<Transform>().position.y > temp[k].GetComponent<Transform>().position.y)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }
                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f)) && !((temp[k].GetComponent<Transform>().position.y == 0) || (temp[k].GetComponent<Transform>().position.x == 0)))
                {

                    if (temp[k].GetComponent<Transform>().position.x > ((M.largeur * 0.24f) - 0.25f))
                    {

                        if (temp[i].GetComponent<Transform>().position.y > temp[k].GetComponent<Transform>().position.y)
                        {

                            GameObject t = temp[k];
                            temp[k] = temp[i];
                            temp[i] = t;

                        }

                    }
                    else
                    {

                        GameObject t = temp[k];
                        temp[k] = temp[i];
                        temp[i] = t;

                    }

                }
                else if ((temp[i].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)) && (temp[k].GetComponent<Transform>().position.y < -((M.hauteur * 0.24f) - 0.25f)))
                {

                    GameObject t = temp[k];
                    temp[k] = temp[i];
                    temp[i] = t;

                }

            }

        }
    }

}
