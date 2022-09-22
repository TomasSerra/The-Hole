using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarPuntos : MonoBehaviour {

    public Text textoPuntos;
    public Text textoPuntosAct;
    public Text record;
    public GameObject[] textosAviso;
    private bool mostrado = false;

    int punto;
    public Destruirenemigos scriptPuntos;

	void Start () {
        punto = 0;
        record.text = GetMaxScore().ToString();
	}
	
	
	void Update () 
    {
        punto = scriptPuntos.puntos;

        if (punto%5 == 0 && punto != 0 && mostrado == false)
        {
            int cartel = Random.Range(0, textosAviso.Length);
            StartCoroutine(MostrarCartel(cartel));
            mostrado = true;
        }

        textoPuntos.text = punto.ToString();
        textoPuntosAct.text = punto.ToString();

        if(punto > GetMaxScore())
        {
            record.text = punto.ToString();
            SaveScore(punto);
        }
    }

    public int GetMaxScore()
    {
        return PlayerPrefs.GetInt("Max Score", 0);
    }

    public void SaveScore(int puntosActuales)
    {
        PlayerPrefs.SetInt("Max Score", puntosActuales);
    }

    IEnumerator MostrarCartel(int cartel)
    {
        
        textosAviso[cartel].SetActive(true);
        yield return new WaitForSeconds(3);
        textosAviso[cartel].SetActive(false);
        yield return new WaitForSeconds(3);
        mostrado = false;
    }
}
