using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaEpica : MonoBehaviour
{

    int monedasAct;

    public int monedasParaDesblq;
    public GameObject[] skins;
    public Transform spawnerSkin;

    void Start()
    {
        //BorrarMemoria();
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    void Update()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;

        if (GetCoins() <= monedasParaDesblq)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void BorrarMemoria()
    {
        SaveSkin4(0);
        SaveSkin5(0);
        SaveSkin6(0);
    }

    void OnMouseDown()
    {
        monedasAct = GetCoins();
        GetComponent<Animator>().SetBool("Tocada", true);
        Debug.Log("Quedan: " + monedasAct);

        if (monedasAct >= monedasParaDesblq)
        {
            GastarMonedas();
        }
        else
        {
            Debug.Log("Monedas insuficientes");
        }
    }

    public int GetCoins()
    {
        return PlayerPrefs.GetInt("Monedas", 0);
    }

    public void SaveCoins(int monedasActuales)
    {
        PlayerPrefs.SetInt("Monedas", monedasActuales);
    }

    void GastarMonedas()
    {
        if (GetSkin4() == 1 & GetSkin5() == 1 & GetSkin6() == 1)
        {
            Debug.Log("Ya tienes todos los skins");
        }
        else
        {
            monedasAct = monedasAct - monedasParaDesblq;
            SaveCoins(monedasAct);
            GenerarSkin();
        }
    }

    void GenerarSkin()
    {
        int numSkin = Random.Range(0, skins.Length);

        if (numSkin == 0)
        {

            if (GetSkin4() == 0)
            {
                SaveSkin4(1);
                StartCoroutine(AparecerSkin(numSkin));
            }
            else
            {
                GenerarSkin();
            }

        }

        else if (numSkin == 1)
        {

            if (GetSkin5() == 0)
            {
                SaveSkin5(1);
                StartCoroutine(AparecerSkin(numSkin));
            }
            else
            {
                GenerarSkin();
            }

        }

        else if (numSkin == 2)
        {

            if (GetSkin6() == 0)
            {
                SaveSkin6(1);
                StartCoroutine(AparecerSkin(numSkin));
            }
            else
            {
                GenerarSkin();
            }

        }

        Debug.Log(numSkin);

    }

    //Skin 4
    public int GetSkin4()
    {
        return PlayerPrefs.GetInt("Skin4", 0);
    }

    public void SaveSkin4(int skin4)
    {
        PlayerPrefs.SetInt("Skin4", skin4);
    }

    //Skin 5
    public int GetSkin5()
    {
        return PlayerPrefs.GetInt("Skin5", 0);
    }

    public void SaveSkin5(int skin5)
    {
        PlayerPrefs.SetInt("Skin5", skin5);
    }

    //Skin 6
    public int GetSkin6()
    {
        return PlayerPrefs.GetInt("Skin6", 0);
    }

    public void SaveSkin6(int skin6)
    {
        PlayerPrefs.SetInt("Skin6", skin6);
    }


    IEnumerator AparecerSkin(int numSkin)
    {
        this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        skins[numSkin].transform.position = spawnerSkin.position;
        skins[numSkin].SetActive(true);
        yield return new WaitForSeconds(2);
        skins[numSkin].SetActive(false);
        GetComponent<Animator>().SetBool("Tocada", false);
        this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}