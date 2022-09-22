using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionarSkin : MonoBehaviour {

    public string playerPrefAcceder;
    public bool puedeSeleccionar = false;


	void Start ()
    {
        if (GetSkin() == 1)
        {
            puedeSeleccionar = true;
        }
    }
	

    int GetSkin()
    {
        return PlayerPrefs.GetInt(playerPrefAcceder, 0);
    }

}
