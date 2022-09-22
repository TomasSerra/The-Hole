using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruirenemigos : MonoBehaviour {

    [HideInInspector] public int puntos;
    GameObject item;
    Movimiento personaje;
    public AudioSource muerteEnemigo;


    void Start()
    {
        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo") && personaje.muerto == false) 
        {
            SumarPuntos();
            muerteEnemigo.Play();
        }
        else if (other.CompareTag("Item"))
        {
            item = GameObject.FindGameObjectWithTag("Item");
            Destroy(item);
        }
        else if (other.CompareTag("Moneda"))
        {
            item = GameObject.FindGameObjectWithTag("Moneda");
            Destroy(item);
        }
    }

    public void SumarPuntos()
    {
        puntos = puntos + 1;
    }


}
