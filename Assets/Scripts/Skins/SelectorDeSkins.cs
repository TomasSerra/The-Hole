using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorDeSkins : MonoBehaviour {

    public GameObject[] activados;
    public GameObject[] bloqueados;

	void Start ()
    {
        for (int i = 0; i < activados.Length; i++)
        {
            if (SkinSeleccionado() == i)
            {
                activados[SkinSeleccionado()].SetActive(true);
            }
            else
            {
                activados[i].SetActive(false);
            }
        }

        if (GetSkin1() == 1)
        {
            Destroy(bloqueados[0]);
        }

        if (GetSkin2() == 1)
        {
            Destroy(bloqueados[1]);
        }

        if (GetSkin3() == 1)
        {
            Destroy(bloqueados[2]);
        }

        if (GetSkin4() == 1)
        {
            Destroy(bloqueados[3]);
        }

        if (GetSkin5() == 1)
        {
            Destroy(bloqueados[4]);
        }
    }


	
	
    public void SeleccionSkin(int skin)
    {
        if (skin == 0)
        {
            activados[0].SetActive(true);
            activados[1].SetActive(false);
            activados[2].SetActive(false);
            activados[3].SetActive(false);
            activados[4].SetActive(false);
            activados[5].SetActive(false);
            GuardarSkinSeleccionado(0);
        } 

        else if(skin == 1)
        {
            activados[0].SetActive(false);
            activados[1].SetActive(true);
            activados[2].SetActive(false);
            activados[3].SetActive(false);
            activados[4].SetActive(false);
            activados[5].SetActive(false);
            GuardarSkinSeleccionado(1);
        }

        else if (skin == 2)
        {
            activados[0].SetActive(false);
            activados[1].SetActive(false);
            activados[2].SetActive(true);
            activados[3].SetActive(false);
            activados[4].SetActive(false);
            activados[5].SetActive(false);
            GuardarSkinSeleccionado(2);
        }

        else if (skin == 3)
        {
            activados[0].SetActive(false);
            activados[1].SetActive(false);
            activados[2].SetActive(false);
            activados[3].SetActive(true);
            activados[4].SetActive(false);
            activados[5].SetActive(false);
            GuardarSkinSeleccionado(3);
        }

        else if (skin == 4)
        {
            activados[0].SetActive(false);
            activados[1].SetActive(false);
            activados[2].SetActive(false);
            activados[3].SetActive(false);
            activados[4].SetActive(true);
            activados[5].SetActive(false);
            GuardarSkinSeleccionado(4);
        }

        else if (skin == 5)
        {
            activados[0].SetActive(false);
            activados[1].SetActive(false);
            activados[2].SetActive(false);
            activados[3].SetActive(false);
            activados[4].SetActive(false);
            activados[5].SetActive(true);
            GuardarSkinSeleccionado(5);
        }
    }

    public int GetSkin1()
    {
        return PlayerPrefs.GetInt("Skin1", 0);
    }

    public int GetSkin2()
    {
        return PlayerPrefs.GetInt("Skin2", 0);
    }

    public int GetSkin3()
    {
        return PlayerPrefs.GetInt("Skin3", 0);
    }

    public int GetSkin4()
    {
        return PlayerPrefs.GetInt("Skin4", 0);
    }

    public int GetSkin5()
    {
        return PlayerPrefs.GetInt("Skin5", 0);
    }

    public int SkinSeleccionado()
    {
        return PlayerPrefs.GetInt("SkinSeleccionado", 0);
    }

    public void GuardarSkinSeleccionado(int skin)
    {
        PlayerPrefs.SetInt("SkinSeleccionado", skin);
    }

}
