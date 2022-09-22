using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaComun : MonoBehaviour {

    int monedasAct;


    public int monedasParaDesblq;
    public GameObject[] skins;
    public Transform spawnerSkin;

	void Start () 
    {
        //BorrarMemoria();
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }

    void BorrarMemoria()
    {
        SaveSkin1(0);
        SaveSkin2(0);
        SaveSkin3(0);
    }

    void Update()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = true;

        if (GetCoins() <= monedasParaDesblq)
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = false; 
        } 
    }

    void OnMouseDown()
    {
        monedasAct = GetCoins();
        GetComponent<Animator>().SetBool("Tocada", true);
        //Debug.Log("Quedan: " + monedasAct);

        if (monedasAct >= monedasParaDesblq)
        {
            GastarMonedas();
        }
        else
        {
            //Debug.Log("Monedas insuficientes");
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
        if (GetSkin1() == 1 & GetSkin2() == 1 & GetSkin3() == 1)
        {
            Debug.Log("Ya tienes todos los skins");
        }
        else
        {
            monedasAct -= monedasParaDesblq;
            SaveCoins(monedasAct);
            GenerarSkin();
        }
    }

    void GenerarSkin()
    {
        int numSkin = Random.Range(0, skins.Length);

        if (numSkin == 0)
        {
             
            if (GetSkin1() == 0)
            {
                SaveSkin1(1);
                StartCoroutine(AparecerSkin(numSkin));
            }
            else
            {
                GenerarSkin();
            }

        }

        else if (numSkin == 1)
        {
             
            if (GetSkin2() == 0)
            {
                SaveSkin2(1);
                StartCoroutine(AparecerSkin(numSkin));
            }
            else
            {
                GenerarSkin();
            }

        }

        else if (numSkin == 2)
        {
            
            if (GetSkin3() == 0)
            {
                SaveSkin3(1);
                StartCoroutine(AparecerSkin(numSkin));
            }
            else
            {
                GenerarSkin();
            }

        }

        else if (numSkin == 3)
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

        else if (numSkin == 4)
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
            
            //Debug.Log(numSkin);

    }

    //Skin 1
    public int GetSkin1()
    {
        return PlayerPrefs.GetInt("Skin1", 0);
    }

    public void SaveSkin1(int skin1)
    {
        PlayerPrefs.SetInt("Skin1", skin1);

    }

    //Skin 2
    public int GetSkin2()
    {
        return PlayerPrefs.GetInt("Skin2", 0);
    }

    public void SaveSkin2(int skin2)
    {
        PlayerPrefs.SetInt("Skin2", skin2);

    }

    //Skin 3
    public int GetSkin3()
    {
        return PlayerPrefs.GetInt("Skin3", 0);
    }

    public void SaveSkin3(int skin3)
    {
        PlayerPrefs.SetInt("Skin3", skin3);

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
