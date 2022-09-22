using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monedas : MonoBehaviour {

    int MonedasActuales;
    public Text monedasTexto;

	void Update ()
    {
        monedasTexto.text = GetCoins().ToString();
    }
	
    public void SumarMonedas()
    {
        MonedasActuales = GetCoins() + 2;
        SaveCoins(MonedasActuales);
        monedasTexto.text = GetCoins().ToString();
    }

    public int GetCoins()
    {
        return PlayerPrefs.GetInt("Monedas", 0);
    }

    public void SaveCoins(int monedasActuales)
    {
        PlayerPrefs.SetInt("Monedas", monedasActuales);
    }

}
