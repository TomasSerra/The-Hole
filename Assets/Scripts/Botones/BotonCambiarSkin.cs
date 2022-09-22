using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCambiarSkin : MonoBehaviour {

    private GameObject scriptManager;
    private int skin;

    void Start()
    {
        scriptManager = GameObject.FindGameObjectWithTag("Manager");
    }


    public void SeleccionSkin(int numeroSkin)
    {
        skin = numeroSkin;
    }

    public void SkinAcceder(string playerPrefAcceder)
    {
        PlayerPrefs.SetInt("Skin0", 1);
        if (PlayerPrefs.GetInt(playerPrefAcceder, 0) == 1)
        {
            Seleccionar();
        }
    }

    void Seleccionar ()
    {
        scriptManager.GetComponent<SelectorDeSkins>().SeleccionSkin(skin);
    }


}
