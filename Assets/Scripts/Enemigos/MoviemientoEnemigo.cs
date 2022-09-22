using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviemientoEnemigo : MonoBehaviour {

    Rigidbody2D rigidbodyEnemigo;
    public float velocidad;
    Movimiento personaje;

	void Start () {
        rigidbodyEnemigo = GetComponent<Rigidbody2D>();
        personaje = GameObject.FindGameObjectWithTag("Player").GetComponent<Movimiento>();
    }
	
	
	void FixedUpdate () {
       
        if(personaje.muerto == false)
        {
            Vector2 vectorVelocidad = new Vector2(0, -1) * velocidad;
            rigidbodyEnemigo.velocity = vectorVelocidad;
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
