using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour {

    Rigidbody2D rigidbodyEnemigo;
    public int velocidad;
    Movimiento personaje;

    void Start()
    {
        rigidbodyEnemigo = GetComponent<Rigidbody2D>();
        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>();
        StartCoroutine(Mover());
    }

    IEnumerator Mover()
    {

        if (personaje.muerto == false)
        {
            Vector2 vectorVelocidad = new Vector2(0, -1) * velocidad;
            rigidbodyEnemigo.velocity = vectorVelocidad;
            yield return new WaitForSeconds(1);
            
            vectorVelocidad = new Vector2(0, 1) * velocidad;
            rigidbodyEnemigo.velocity = vectorVelocidad;
            yield return new WaitForSeconds(0.5f);

            vectorVelocidad = new Vector2(0, -1) * velocidad;
            rigidbodyEnemigo.velocity = vectorVelocidad;
            yield return new WaitForSeconds(2);

            vectorVelocidad = new Vector2(0, 1) * velocidad;
            rigidbodyEnemigo.velocity = vectorVelocidad;
            yield return new WaitForSeconds(0.5f);

            vectorVelocidad = new Vector2(0, -1) * velocidad;
            rigidbodyEnemigo.velocity = vectorVelocidad;
            yield return new WaitForSeconds(5);
        }
        else
        {
            rigidbodyEnemigo.velocity = new Vector2(0, 0);
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Destructor"))
        {
            Destroy(this.gameObject);
        }
    }
}
