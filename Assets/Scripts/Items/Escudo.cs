using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escudo : MonoBehaviour {

    Destruirenemigos puntuacion;

    public int duracion;
    public Color color;
    public Color apagar;
    public Transform jugador;

	void Start () {
        gameObject.GetComponent<SpriteRenderer>().color = apagar;
        GetComponent<CircleCollider2D>().enabled = false;
    }

    public void Activar()
    {
        StartCoroutine(ActivarEscudo());
    }

    void Update()
    {
        gameObject.transform.position = jugador.position;
    }


    public IEnumerator ActivarEscudo()
    {

        gameObject.GetComponent<SpriteRenderer>().color = color;
        GetComponent<CircleCollider2D>().enabled = true;
        yield return new WaitForSeconds(duracion);
        gameObject.GetComponent<SpriteRenderer>().color = apagar;
        GetComponent<CircleCollider2D>().enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemigo"))
        {
            puntuacion = GameObject.FindGameObjectWithTag("Destructor").GetComponent<Destruirenemigos>();
            puntuacion.SumarPuntos();
            Destroy(GameObject.FindGameObjectWithTag("Enemigo"));

        }
    }
}
